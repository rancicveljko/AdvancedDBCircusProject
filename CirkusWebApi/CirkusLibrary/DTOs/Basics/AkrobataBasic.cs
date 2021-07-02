using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class AkrobataBasic : ArtistBasic
    {
        [JsonIgnore]
        public IList<VestinaBasic> Vestine { get; set; }

        public AkrobataBasic()
        {


        }
        public AkrobataBasic(int id, String ime, string imeRod, String prez, long matBr, String UmIme, String pol, DateTime clan) : base(id, ime, imeRod, prez, matBr, UmIme, pol, clan)
        {

        }
        public AkrobataBasic(Akrobata a)
        {
            this.ArtistId = a.IdPerformera;
            this.ImeArtista = a.JeZaposleni.Ime;
            this.PrezimeArtista = a.JeZaposleni.Prezime;
            this.UmetnickoIme = a.UmetnickoIme;
            this.Pol = a.Pol;
            this.ClanOd = a.ClanOd;
            this.Zaposleni = new ZaposleniBasic(a.JeZaposleni);
            foreach (var item in a.Vestine)
            {
                this.Vestine.Add(new VestinaBasic(item));
            }
        }
    }
}
