using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class KlovnBasic : ArtistBasic
    {
        public String Tip { get; set; }
        public String CimeZabavlja { get; set; }

        public KlovnBasic()
        {

        }
        public KlovnBasic(int id, String ime, string imeRod, String prez, long matBr, String UmIme, String pol, string tip, String cime, DateTime clan) : base(id, ime, imeRod, prez, matBr, UmIme, pol, clan)
        {
            this.Tip = tip;
            this.CimeZabavlja = cime;
        }
        public KlovnBasic(Klovn k) : base(k)
        {
            this.Tip = k.Tip;
            this.CimeZabavlja = k.CimeZabavlja;
        }
    }
}
