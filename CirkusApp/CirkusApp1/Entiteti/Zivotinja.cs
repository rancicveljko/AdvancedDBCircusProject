using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Zivotinja
    {
        public virtual int IdPerformera { get; set; }
        public virtual String UmetnickoIme { get; set; }
        public virtual String Pol { get; set; }
        public virtual DateTime ClanOd { get; set; }
        public virtual String Vrsta { get; set; }
        public virtual DateTime ZadnjiPregled { get; set; }
        public virtual float Tezina { get; set; }
        public virtual int BrojKaveza { get; set; }
        public virtual int Starost { get; set; }

        public virtual Dreser DresiraZivotinju { get; set; }

        public Zivotinja()
        {

        }
    }
}
