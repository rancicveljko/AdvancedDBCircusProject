using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class DreserBasic : ArtistBasic
    {
        public virtual IList<ZivotinjaBasic> Zivotinje { get; set; }
        //public virtual IList<PomocnoOsobljeBasic> Asistenti { get; set; }

        public DreserBasic()
        {
            Zivotinje = new List<ZivotinjaBasic>();
            //Asistenti=new List<PomocnoOsobljeBasic>();
        }
        public DreserBasic( String ime, String prez, String UmIme, String pol, DateTime clan) : base( ime, prez, UmIme, pol, clan)
        {

        }

    }
}
