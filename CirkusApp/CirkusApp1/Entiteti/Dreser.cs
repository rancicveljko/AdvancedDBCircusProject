using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Dreser:Artist
    {
        

        public virtual IList<Zivotinja> Zivotinje { get; set; }

        public Dreser()
        {
            Zivotinje = new List<Zivotinja>();
        }
    }
}
