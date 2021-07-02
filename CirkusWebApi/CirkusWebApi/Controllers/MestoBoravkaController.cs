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
    public class MestoBoravkaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMestaBoravka")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMestaBoravka()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSvaMestaBoravka());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajMestoBoravka")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajMestoBoravka([FromBody] MestoBoravkaBasic mestoBoravka)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.dodajMestoBoravka(mestoBoravka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniMestoBoravka")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniMestoBoravka([FromBody] MestoBoravkaBasic mestoBoravka)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.azurirajMestoBoravka(mestoBoravka);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiMestoBoravka/{mestoBoravkaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ObrisiMestoBoravka([FromRoute] int mestoBoravkaID)
        {

            try
            {
                DTOManager.obrisiMestoBoravka(mestoBoravkaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


    }
}