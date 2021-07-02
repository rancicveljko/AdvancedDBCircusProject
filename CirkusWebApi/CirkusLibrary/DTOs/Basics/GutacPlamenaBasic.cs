using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class GutacPlamenaBasic : ArtistBasic
    {
        public IList<PomocnoOsobljeBasic> Asistenti { get; set; }

        public GutacPlamenaBasic()
        {
            Asistenti = new List<PomocnoOsobljeBasic>();
        }
        public GutacPlamenaBasic(int id, String ime, string imeRod, String prez, long matBr, String UmIme, String pol, DateTime clan) : base(id, ime, imeRod, prez, matBr, UmIme, pol, clan)
        {

        }
    }
}
