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
    public class CirkuskaPredstavaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSvePredstave")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMestaBoravka()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSveCirkuskePredstave());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiPredstave/{mestoboravkaID}")]//preuzimamo predstave iz odredjenog mesta
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getPredstave(int mestoboravkaID)
        {
            try
            {

                return new JsonResult(DTOManager.vratiPredstaveMesta(mestoboravkaID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSveHumanitarnePredstave")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PreuzmiSveHumanitarnePredstave()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSveHumanitarnePredstave());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajCirkuskuPredstavu/{mestoboravkaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajPredstavu(int mestoboravkaId,[FromBody] CirkuskaPredstavaBasic predstava)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                var mestoboravka = DTOManager.vratiMestoBoravka(mestoboravkaId);
                predstava.Mesto = mestoboravka;
                DTOManager.dodajCirkuskuPredstavu(predstava);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajHumanitarnuPredstavu/{mestoboravkaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajHumanitarnuPredstavu(int mestoboravkaId, [FromBody] HumanitarnaPredstavaBasic predstava)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                var mestoboravka = DTOManager.vratiMestoBoravka(mestoboravkaId);
                predstava.Mesto = mestoboravka;
                DTOManager.dodajHumanitarnuPredstavu(predstava);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniPredstavu")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniCirkuskuPredstavu([FromBody] CirkuskaPredstavaBasic cirkuskaPredstava)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.azurirajCirkuskuPredstavu(cirkuskaPredstava);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiCirkuskuPredstavu/{predstavaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiCirkuskuPredstavu(int predstavaId)
        {

            try
            {
                DTOManager.obrisiCirkuskuPredstavu(predstavaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiHumanitarnuPredstavu/{predstavaId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult ObrisiHumanitarnuPredstavu(int predstavaId)
        {

            try
            {
                DTOManager.obrisiCirkuskuPredstavu(predstavaId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
