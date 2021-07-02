using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CirkusWebApi.Controllers
{
    [ApiController]
    [Route("Vestine")]
    public class VestinaController : ControllerBase
    {
        [HttpGet]
        [Route("VratiSveVestineAkrobate/{akrobataID}")]
        public IActionResult vratiSveVestineAkrobate([FromRoute] int akrobataID)
        {
            try
            {
                return new JsonResult(DTOManager.VratiSveVestineAkrobate(akrobataID));
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpGet]
        [Route("vratiSveAkrobateSaOdredjenomVestinom/{vestinaID}")]
        public IActionResult vratiSveAkrobateSaOdredjenomVestinom([FromRoute] int vestinaID)
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveAkrobateSaOdredjenomVestinom(vestinaID));
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpPost]
        [Route("DodajVestinu/{id}")]
        public IActionResult DodajVestinu([FromBody]VestinaBasic vestina, [FromRoute]int id)
        {
            try
            {
                DTOManager.DodajVestinu(vestina, id);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
    }
}
