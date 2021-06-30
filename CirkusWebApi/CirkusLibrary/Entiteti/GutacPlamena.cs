using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class GutacPlamena:Artist
    {
        public virtual IList<PomocnoOsoblje> Asistenti { get; set; }

        public GutacPlamena()
        {
            Asistenti = new List<PomocnoOsoblje>();
        }

    }
}
