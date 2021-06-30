using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Akrobata: Artist
    {
        public virtual IList<Vestina> Vestine { get; set; }

        public Akrobata()
        {
            Vestine = new List<Vestina>();
        }

    }
}
