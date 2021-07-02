using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CirkusWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NastupnaTackaController:ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveNastupneTacke")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNastupneTacke()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSveNastupneTacke());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSveNastupneTacke/{predstavaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getNastupnetackePredstave([FromRoute] int predstavaID)
        {
            try
            {

                return new JsonResult(DTOManager.vratiNastupneTackePredstave(predstavaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajNastupnuTacku/{predstavaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajNastupnuTacku([FromRoute] int predstavaID, [FromBody] NastupnaTackaBasic tacka)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                var predstava = DTOManager.vratiCirkuskuPredstavu(predstavaID);
                tacka.Predstava= predstava;
                DTOManager.dodajNastupnuTacku(tacka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiNastupnuTacku/{nastupnatackaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiNastupnuTacku(int nastupnatackaID)
        {

            try
            {
                DTOManager.obrisiNastupnuTacku(nastupnatackaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniNastupnuTacku")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniNastupnuTacku([FromBody] NastupnaTackaBasic nastupnaTacka)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.azurirajNastupnuTacku(nastupnaTacka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
