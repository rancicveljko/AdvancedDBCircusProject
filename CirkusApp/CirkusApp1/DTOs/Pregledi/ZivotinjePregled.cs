using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    class ZivotinjaPregled
    {
        public int IdZivotinja { get; set; }
        public String UmetnickoIme { get; set; }
        public String Vrsta { get; set; }
        public String Pol { get; set; }
        public int Starost { get; set; }

        public ZivotinjaPregled()
        {

        }
        public ZivotinjaPregled(int id, String ime, String vrs, String pol, int starost)
        {
            this.IdZivotinja = id;
            this.UmetnickoIme = ime;
            this.Vrsta = vrs;
            this.Pol = pol;
            this.Starost = starost;
        }
    }
}
