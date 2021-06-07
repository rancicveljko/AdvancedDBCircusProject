using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class ZonglerPregled : ArtistPregled
    {
        public String NazivPredmeta { get; set; }
        public int MaxPredmeta { get; set; }

        public ZonglerPregled()
        {

        }
        public ZonglerPregled(int id, String UmIme, String pol, String naziv, int max) : base(id, UmIme, pol)
        {
            this.NazivPredmeta = naziv;
            this.MaxPredmeta = max;
        }
    }
}
