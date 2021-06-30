using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class VestinaPregled
    {
        public int IdVestine { get; set; }
        public String Naziv { get; set; }
        public int GodinaIskustva { get; set; }

        public VestinaPregled()
        {
            
        }
        public VestinaPregled(int idvest, String naziv, int god)
        {
            this.IdVestine = idvest;
            this.Naziv = naziv;
            this.GodinaIskustva = god;
        }
    }
}
