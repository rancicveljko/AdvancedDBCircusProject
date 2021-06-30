using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class CirkuskaPredstavaPregled
    {
        public virtual int IdPredstave { get; protected set; }
        public virtual DateTime Vreme { get; set; }
        public virtual int BrojKarata { get; set; }
        public string Mesto { get; set; }

        public CirkuskaPredstavaPregled()
        {
            
        }
        public CirkuskaPredstavaPregled(int idPredstave, DateTime vreme, int brojKarata, string mesto)
        {
            this.IdPredstave = idPredstave;
            this.Vreme = vreme;
            this.BrojKarata = brojKarata;
            this.Mesto = mesto;
        }
    }
}
