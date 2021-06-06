using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class PomocnoOsoblje : Zaposleni
    {
        public virtual Boolean AsistentFleg { get; set; }
        public virtual int IdPerformera { get; set; }
    
    }

}