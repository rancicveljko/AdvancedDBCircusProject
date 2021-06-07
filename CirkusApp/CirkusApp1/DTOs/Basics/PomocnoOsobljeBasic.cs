using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class PomocnoOsobljeBasic : ZaposleniBasic
    {
        public virtual Boolean AsistentFleg { get; set; }
        public virtual ArtistBasic PomazeArtistu { get; set; }

        //public virtual Dreser RadiSa { get; set; }
        //public virtual BacacNozeva Radi_Sa { get; set; }
        //public virtual GutacPlamena Radi__Sa { get; set; }

        public PomocnoOsobljeBasic()
        {

        }

        public PomocnoOsobljeBasic(int id, string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr, Boolean asistent):base(id, ime, imer, prez, datrodj,  mrodj,  mbr)
        {
            this.AsistentFleg = asistent;
        }
    }
}
