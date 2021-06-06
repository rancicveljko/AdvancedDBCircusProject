using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Vestina
    {
        public virtual int IdVestine { get; set; }
        public virtual String Naziv { get; set; }
        public virtual int GodinaIskustva { get; set; }
        public virtual IList<Akrobata> Akrobate { get; set;  }

        public Vestina()
        {
            Akrobate = new List<Akrobata>();
        }
    }
}
