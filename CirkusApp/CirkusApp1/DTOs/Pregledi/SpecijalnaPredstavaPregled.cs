using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class SpecijalnaPredstavaPregled : CirkuskaPredstavaPregled
    {
        public SpecijalnaPredstavaPregled()
        {

        }
        public SpecijalnaPredstavaPregled(int idPredstave, DateTime vreme, int brojKarata) : base(idPredstave, vreme, brojKarata)
        {

        }
    }
}
