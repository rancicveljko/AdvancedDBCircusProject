using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

    }
}
