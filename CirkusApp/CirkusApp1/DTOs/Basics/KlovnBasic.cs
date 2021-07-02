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
        public KlovnBasic( int id,String ime, String prez, String UmIme, String pol, string tip, String cime, DateTime clan) : base( id,ime, prez, UmIme, pol, clan)
        {
            this.Tip = tip;
            this.CimeZabavlja = cime;
        }
    }
}
