using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
        [JsonIgnore]
        public DreserBasic DresiraZivotinju { get; set; }//mogli smo i id dresera da stavimo a mozemo i preko lazy load da ucitamo dresera

        public String ImeDresera { get; set; }

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
        public ZivotinjaBasic(Zivotinja z)
        {
            this.IdPerformera = z.IdPerformera;
            this.UmetnickoIme = z.UmetnickoIme;
            this.Pol = z.Pol;
            this.ClanOd = z.ClanOd;
            this.Vrsta = z.Vrsta;
            this.Tezina = z.Tezina;
            this.Starost = z.Starost;
            this.ImeDresera = z.DresiraZivotinju.JeZaposleni.Ime;
        }
    }
}
