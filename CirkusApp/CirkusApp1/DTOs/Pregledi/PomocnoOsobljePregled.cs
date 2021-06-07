using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class PomocnoOsobljePregled :ZaposleniPregled
    {
        public virtual Boolean AsistentFleg { get; set; }

        public PomocnoOsobljePregled()
        {

        }
        public PomocnoOsobljePregled(int id, string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr, Boolean asistent):base(id, ime,  imer,  prez,  datrodj,  mrodj,  mbr)
        {
            this.AsistentFleg = asistent;
        }
    }
}
