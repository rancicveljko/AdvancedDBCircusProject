using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Artist
    {
        public virtual int IdPerformera { get; protected set; }
        public virtual int IdZaposlenog { get; set; }
        public virtual String UmetnickoIme { get; set; }
        public virtual String Pol { get; set; }
        public virtual DateTime ClanOd{ get; set; }

        public Artist()
        {

        }
    }
}
