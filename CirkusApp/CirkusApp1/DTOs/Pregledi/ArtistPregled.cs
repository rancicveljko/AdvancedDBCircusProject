using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class ArtistPregled
    {
        public int ArtistId { get; set; }
        public String UmetnickoIme { get; set; }
        public String Pol { get; set; }
        //public DateTime ClanOd { get; set; }

        public ArtistPregled()
        {

        }
        public ArtistPregled(int id, String umime, String pol)
        {
            this.ArtistId = id;
            this.UmetnickoIme = umime;
            this.Pol = pol;
        }

    }
}
