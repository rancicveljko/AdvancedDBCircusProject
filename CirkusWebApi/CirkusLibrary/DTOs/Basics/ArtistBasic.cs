using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ArtistBasic
    {
        public int ArtistId { get; set; }
        public String ImeArtista { get; set; }
        public String PrezimeArtista { get; set; }
        public String UmetnickoIme { get; set; }
        public String Pol { get; set; }
        public DateTime ClanOd { get; set; }
        [JsonIgnore]
        public ZaposleniBasic Zaposleni { get; set; }
        public ArtistBasic()
        {

        }
        public ArtistBasic( int id,String ime, String prez, String UmIme, String pol, DateTime clan)
        {
            this.ArtistId = id;
            this.ImeArtista = ime;
            this.PrezimeArtista = prez;
            this.UmetnickoIme = UmIme;
            this.Pol = pol;
            this.ClanOd = clan;
        }
        public ArtistBasic(int id, string umIme, string pol)
        {
            this.ArtistId = id;
            this.UmetnickoIme = umIme;
            this.Pol = pol;
        }
        public ArtistBasic(int id, string umIme, string pol, String ime, String prezime)
        {
            this.ImeArtista = ime;
            this.PrezimeArtista = prezime;
            this.ArtistId = id;
            this.UmetnickoIme = umIme;
            this.Pol = pol;
        }
        public ArtistBasic(Artist art)
        {
            this.ArtistId = art.IdPerformera;
            this.ImeArtista = art.JeZaposleni.Ime;
            this.PrezimeArtista = art.JeZaposleni.Prezime;
            this.UmetnickoIme = art.UmetnickoIme;
            this.Pol = art.Pol;
            this.ClanOd = art.ClanOd;
        }

    }
}
