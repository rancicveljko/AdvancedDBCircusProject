using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Artist 
    {
        public virtual int IdPerformera { get;  set; }
        public virtual Zaposleni JeZaposleni { get; set; }
        public virtual String UmetnickoIme { get; set; }
        public virtual String Pol { get; set; }
        public virtual DateTime ClanOd{ get; set; }

        public Artist()
        {
            JeZaposleni = new Zaposleni();
        }
    }
}
