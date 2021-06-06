using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class NastupnaTacka
    {
        public virtual int IdTacke { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Tip { get; set; }
        public virtual int MinGodina { get; set; }
        public virtual int OpasniEfekti { get; set; }
        public virtual CirkuskaPredstava Predstava { get; set; }

        public NastupnaTacka()
        {

        }
    }
}
