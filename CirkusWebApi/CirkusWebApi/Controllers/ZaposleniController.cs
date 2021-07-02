using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using CirkusApp1.Entiteti;
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
    public class ZaposleniController : ControllerBase
    {
        #region Zaposleni
        [HttpPost]
        [Route("DodajZaposlenog")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DodajZaposlenog([FromBody] ZaposleniBasic zaposleniUlaz)
        {
            try
            {
                DTOManager.dodajZaposlenog(zaposleniUlaz);

                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message.ToString());
            }
        }


        [HttpGet]
        [Route("VratiSveZaposlene")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ZaposleniBasic> VratiSveZaposlene()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSveZaposlene());
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message.ToString());
            }
        }
        [HttpGet]
        [Route("VratiZaposlenog/{zaposleniID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<ZaposleniBasic> VratiZaposlenog([FromRoute(Name = "zaposleniID")] int id)
        {
            try
            {
                var zaposleni = DTOManager.vratiZaposlenog(id);
                if (zaposleni != null)
                    return new JsonResult(zaposleni);
                return BadRequest();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiZaposlenog/{zaposleniID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ObrisiZaposlenog([FromRoute(Name = "zaposleniID")] int id)
        {
            try
            {
                DTOManager.obrisiZaposlenog(id);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message.ToString());
            }
        }
        [HttpPut]
        [Route("AzurirajZaposlenog")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AzurirajZaposlenog([FromBody] ZaposleniBasic zb)
        {
            try
            {
                if (zb.IdZaposlenog == 0)
                    return BadRequest("Mora se proslediti id zaposlenog");

                DTOManager.azurirajZaposlene(zb);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.Message.ToString());
            }
        }
        #endregion
        #region PomocnoOsoblje
        [HttpGet]
        [Route("VratiSvoPomocnoOsoblje")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<List<PomocnoOsobljeBasic>> VratiSvoPomocnoOsoblje()
        {
            try
            {
                return new JsonResult(DTOManager.vratiSvoPomocnoOsoblje());
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpPost]
        [Route("DodajPomocnoOsoblje")]
        public IActionResult DodajPomocnoOsoblje(PomocnoOsobljeBasic pomocnoOsobljeBasic)
        {
            try
            {
                DTOManager.dodajPomocnoOsoblje(pomocnoOsobljeBasic);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpGet]
        [Route("VratiPomocnuOsobu/{id}")]
        public ActionResult<PomocnoOsobljeBasic> VratiPomocnuOsobu([FromRoute] int id)
        {
            try
            {
                var osoba = DTOManager.vratiPomocnuOsobu(id);
                if (osoba == null)
                    return BadRequest("Pomocna osoba sa tim idijem ne postoji");
                return new JsonResult(osoba);
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpPut]
        [Route("AzurirajPomocnuOsobu")]
        public IActionResult AzurirajPomocnuOsobu(PomocnoOsobljeBasic pomocnoOsobljeBasic)
        {
            try
            {
                if (pomocnoOsobljeBasic.IdZaposlenog == 0)
                    return BadRequest("Mora da se prosledi IdZaposlenog");
                DTOManager.azurirajPomocnuOsobu(pomocnoOsobljeBasic);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiPomocnuOsobu/{id}")]
        public IActionResult ObrisiPomocnuOsobu([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("id mora da bude >0");
                }
                DTOManager.obrisiPomocnuOsobu(id);
                return Ok();
            }
            catch (Exception ec)
            {
                return BadRequest(ec.ToString());
            }
        }
        #endregion
    }
}
