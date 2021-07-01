using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class CirkuskaPredstavaBasic
    {
        public virtual int IdPredstave { get; protected set; }
        public virtual DateTime Vreme { get; set; }
        public virtual int BrojKarata { get; set; }
        [JsonIgnore]
        public virtual MestoBoravkaBasic Mesto { get; set; }
        public virtual IList<NastupnaTackaBasic> Tacke { get; set; }
        public CirkuskaPredstavaBasic()
        {
            Tacke = new List<NastupnaTackaBasic>();
        }

        public CirkuskaPredstavaBasic(int idPredstave, DateTime vreme, int brojKarata)
        {
            this.IdPredstave = idPredstave;
            this.Vreme = vreme;
            this.BrojKarata = brojKarata;
            Tacke = new List<NastupnaTackaBasic>();
        }
        public CirkuskaPredstavaBasic(CirkuskaPredstava p)
        {
            this.IdPredstave = p.IdPredstave;
            this.Vreme = p.Vreme;
            this.BrojKarata = p.BrojKarata;
        }

    }
}
