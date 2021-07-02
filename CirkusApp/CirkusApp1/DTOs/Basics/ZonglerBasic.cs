using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZonglerBasic : ArtistBasic
    {
        public String NazivPredmeta { get; set; }
        public int MaxPredmeta { get; set; }

        public ZonglerBasic()
        {

        }
        public ZonglerBasic(int id, String ime, string imeRod, String prez, long matBr, String UmIme, String pol, String naziv, int max, DateTime clan) : base(id, ime, imeRod, prez, matBr, UmIme, pol, clan)
        {
            this.NazivPredmeta = naziv;
            this.MaxPredmeta = max;
        }
    }
}
