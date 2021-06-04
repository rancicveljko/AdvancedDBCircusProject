
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class CirkuskaPredstava
    {
        public virtual int IdPredstave { get; protected set; }
        public virtual DateTime Vreme { get; set; }
        public virtual int BrojKarata { get; set; }
        public virtual MestoBoravka Mesto { get; set; }
        public virtual IList<NastupnaTacka> Tacke { get; set; }

        public CirkuskaPredstava()
        {
            Tacke = new List<NastupnaTacka>();
        }
    }
}
