using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CirkusApp1.Entiteti
{
    public class HumanitarnaPredstava : SpecijalnaPredstava
    {
        public virtual double Prihod { get; set; }
        public virtual string ZaKoga { get; set; }
    }
}
