﻿using CirkusApp1.DTOManagers;
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
        public IActionResult dodajakrobatu(int zaposleniId, [FromBody] AkrobataBasic akrobata)
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
        [HttpPost]
        [Route("DodajAkrobatuIzaposlenog")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajAkrobatuIzaposlenog( [FromBody] AkrobataBasic akrobata)
        {

            try
            {

                //var zap = DTOManager.vratiZaposlenog(zaposleniId);
                //akrobata.Zaposleni = zap;
                DTOManager.dodajAkrobatuIzaposlenog(akrobata);
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
        public IActionResult obrisiAkrobatu(int akrobataId)
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
        public IActionResult PromeniAkrobatu([FromBody] AkrobataBasic akrobata)
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
        #region Dreser
        [HttpGet]
        [Route("PreuzmiSveDresere")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getDreseri()
        {
            try
            {

                return new JsonResult(DTOManager.vratiDresere());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajDresera/{zaposleniId}")]//dodavanje dresera i povezivanje sa vec postojecim zaposlenim koji nema dodeljenog artista
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajDresera(int zaposleniId, [FromBody] DreserBasic dreser)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                var zaposleni = DTOManager.vratiZaposlenog(zaposleniId);
                dreser.Zaposleni = zaposleni;
                DTOManager.dodajDresera(dreser);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiDresera/{dreserId}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiDresera(int dreserId)
        {

            try
            {
                DTOManager.obrisiDresera(dreserId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #endregion
        #region Klovn
        [HttpGet]
        [Route("PreuzmiSveKlovnove")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult getKlovnove()
        {
            try
            {

                return new JsonResult(DTOManager.vratiSveKlovnove());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPost]
        [Route("DodajKlovna")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DodajKlovna([FromBody] KlovnBasic klovn)
        {

            try
            {


                DTOManager.dodajKlovna(klovn);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpDelete]
        [Route("ObrisiKlovna/{klovnID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult obrisiKlovna(int klovnID)
        {

            try
            {
                DTOManager.obrisiKlovna(klovnID);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpPut]
        [Route("PromeniKlovna")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PromeniKlovna([FromBody] KlovnBasic klovn)
        {
            //Iz body-a (ne kroz url) zahteva  prosledimo prodavnicu koju treba da upisemo i sve njene podatke
            try
            {
                DTOManager.azurirajKlovna(klovn);
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
