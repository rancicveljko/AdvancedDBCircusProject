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
    public class ArtistController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveArtiste")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getPreuzmiArtiste()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSveArtiste());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #region Akrobata
        [HttpGet]
        [Route("PreuzmiSveAkrobate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getAkrobate()
        {
            try
            {

                return new JsonResult(DTOManager.vratiAkrobate());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajAkrobatu/{zaposleniId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajNastupnuTacku(int zaposleniId, [FromBody] AkrobataBasic akrobata)
        {

            try
            {

                var zap = DTOManager.vratiZaposlenog(zaposleniId);
                akrobata.Zaposleni = zap;
                DTOManager.dodajAkrobatu(akrobata);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiAkrobatu/{akrobataId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiNastupnuTacku(int akrobataId)
        {

            try
            {
                DTOManager.obrisiAkrobatu(akrobataId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniAkrobatu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniNastupnuTacku([FromBody] AkrobataBasic akrobata)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.AzurirajAkrobatu(akrobata);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
    }
}
