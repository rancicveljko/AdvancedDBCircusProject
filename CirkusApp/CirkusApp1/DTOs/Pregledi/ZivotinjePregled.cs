using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class ZivotinjePregled
    {
        public int IdPerformera;
        public String UmetnickoIme;
        public String Pol;
        public DateTime ClanOd;
        public String Vrsta;
        public float Tezina;
        public int Starost;


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
