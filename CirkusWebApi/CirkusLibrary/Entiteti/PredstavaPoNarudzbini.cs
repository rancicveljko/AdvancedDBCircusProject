using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class PredstavaPoNarudzbini : SpecijalnaPredstava
    {
        public virtual int BrTelNarucioca { get; set; }
        public virtual string NazivNarucioca { get; set; }
        public virtual string AdresaNarucioca { get; set; }
    }
}
