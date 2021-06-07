using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class KlovnPregled : ArtistPregled
    {
        public String Tip { get; set; }
        public String CimeZabavlja { get; set; }

        public KlovnPregled()
        {

        }
        public KlovnPregled(int id, String UmIme, String pol, String tip, String cime) : base(id, UmIme, pol)
        {
            this.Tip = tip;
            this.CimeZabavlja = cime;
        }
    }
}
