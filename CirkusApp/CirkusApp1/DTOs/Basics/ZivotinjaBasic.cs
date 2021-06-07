using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZivotinjaBasic
    {
        public int IdPerformera;
        public String UmetnickoIme;
        public String Pol;
        public DateTime ClanOd;
        public String Vrsta;
        public float Tezina;
        public int Starost;
        public DreserBasic DresiraZivotinju;

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
