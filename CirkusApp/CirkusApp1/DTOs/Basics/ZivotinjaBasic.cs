using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZivotinjaBasic
    {
        public int IdPerformera { get; protected set; }
        public String UmetnickoIme { get; set; }
        public String Pol { get; set; }
        public DateTime ClanOd { get; set; }
        public String Vrsta { get; set; }
        public DateTime ZadnjiPregled { get; set; }
        public float Tezina { get; set; }
        public int BrojKaveza { get; set; }
        public int Starost { get; set; }
        public DreserBasic DresiraZivotinju { get; set; }

        public ZivotinjaBasic()
        {

        }
        public ZivotinjaBasic( String umim, String pol, DateTime clan, String vrst, DateTime zadnjip, float tez, int brkaveza, int starost)
        {
            
            this.UmetnickoIme = umim;
            this.Pol = pol;
            this.ClanOd = clan;
            this.Vrsta = Vrsta;
            this.ZadnjiPregled = zadnjip;
            this.Tezina = tez;
            this.BrojKaveza = brkaveza;
            this.Starost = starost;
        }
    }
}
