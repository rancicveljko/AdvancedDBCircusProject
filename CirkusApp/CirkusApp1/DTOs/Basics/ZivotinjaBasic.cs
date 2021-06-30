using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZivotinjaBasic
    {
        public int IdPerformera { get; set; }
        public String UmetnickoIme { get; set; }
        public String Pol { get; set; }
        public DateTime ClanOd { get; set; }
        public String Vrsta { get; set; }
        public float Tezina { get; set; }
        public int Starost { get; set; }
        public DreserBasic DresiraZivotinju { get; set; }

        public ZivotinjaBasic()
        {

        }
        public ZivotinjaBasic( int id,String umim, String pol, DateTime clan, String vrst, float tez, int starost)
        {
            this.IdPerformera = id;
            this.UmetnickoIme = umim;
            this.Pol = pol;
            this.ClanOd = clan;
            this.Vrsta = vrst;
            this.Tezina = tez;
            this.Starost = starost;
        }
    }
}
