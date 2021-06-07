using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class GutacPlamenaBasic : ArtistBasic
    {
        //public virtual IList<PomocnoOsoblje> Asistenti { get; set; }

        public GutacPlamenaBasic()
        {
            //Asistenti = new List<PomocnoOsoblje>();
        }
        public GutacPlamenaBasic(int id, String ime, String prez, String UmIme, String pol, DateTime clan) : base(id, ime, prez, UmIme, pol, clan)
        {

        }
    }
}
