using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CirkusApp1.Entiteti
{
    public class Zongler:Artist
    {
        public virtual String NazivPredmeta { get; set; }
        public virtual int MaxPredmeta { get; set; }

        public Zongler()
        {

        }
    }
}
