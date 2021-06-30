using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class ZivotinjePregled
    {
        public int IdPerformera { get; set; }
        public String UmetnickoIme { get; set; }
        public String Pol { get; set; }
        public DateTime ClanOd { get; set; }
        public String Vrsta { get; set; }
        public float Tezina { get; set; }
        public int Starost { get; set; }


        public ZivotinjePregled()
        {

        }
        public ZivotinjePregled(int id, String ime,  String pol, DateTime clanod, String vrs, float tez, int starost)
        {
            this.IdPerformera = id;
            this.UmetnickoIme = ime;
            this.Pol = pol;
            this.ClanOd = clanod;
            this.Vrsta = vrs;
            this.Tezina = tez;
            this.Starost = starost;
        }
    }
}
