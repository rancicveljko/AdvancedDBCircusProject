using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class PomocnoOsoblje : Zaposleni
    {
        public virtual Boolean AsistentFleg { get; set; }
        public virtual Artist PomazeArtistu { get; set; }

        //public virtual Dreser RadiSa { get; set; }
        //public virtual BacacNozeva Radi_Sa { get; set; }
        //public virtual GutacPlamena Radi__Sa { get; set; }

        public PomocnoOsoblje()
        {

        }

    }

}