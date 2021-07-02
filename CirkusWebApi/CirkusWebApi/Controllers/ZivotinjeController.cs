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
    public class ZivotinjeController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiZivotinje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetZivotinje()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveZivotinja());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajZivotinju/{dreserId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult AddZivotinja([FromRoute]int dreserId,[FromBody] ZivotinjaBasic zivotinja)
        {
            try
            {
                var dreser = DTOManager.vratiDresera(dreserId);
                zivotinja.DresiraZivotinju = dreser;
                DTOManager.dodajZivotinju(zivotinja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniZivotinju")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ChangeZivotinja([FromBody] ZivotinjaBasic zivotinja)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.azurirajZivotinju(zivotinja);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiZivotinju/{zivotinjaID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteZivotinju([FromRoute]int zivotinjaID)
        {

            try
            {
                DTOManager.obrisiZivotinju(zivotinjaID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}

