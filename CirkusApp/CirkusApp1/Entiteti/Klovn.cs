using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Klovn:Artist
    {
        public virtual String Tip { get; set; }
        public virtual String CimeZabavlja { get; set; }


        public Klovn()
        {

        }
    }
}
