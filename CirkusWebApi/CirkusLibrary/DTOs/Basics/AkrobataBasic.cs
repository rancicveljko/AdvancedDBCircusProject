using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class AkrobataBasic : ArtistBasic
    {
        public  IList<VestinaBasic> Vestine { get; set; }

        public AkrobataBasic()
        {


        }
        public AkrobataBasic(int id, String ime, String prez, String UmIme, String pol, DateTime clan) : base(id, ime, prez, UmIme, pol, clan)
        {

        }
    }
}
