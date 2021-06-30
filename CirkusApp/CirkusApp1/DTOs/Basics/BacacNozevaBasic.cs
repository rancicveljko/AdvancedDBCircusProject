using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class BacacNozevaBasic : ArtistBasic
    {
        public virtual IList<PomocnoOsobljeBasic> Asistenti { get; set; }

        public BacacNozevaBasic()
        {
            Asistenti = new List<PomocnoOsobljeBasic>();
        }
        public BacacNozevaBasic(int id, in String ime, String prez, String UmIme, String pol, DateTime clan) : base(id, ime, prez, UmIme, pol, clan)
        {
            Asistenti = new List<PomocnoOsobljeBasic>();
        }
    }
}
