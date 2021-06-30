using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class SpecijalnaPredstavaBasic : CirkuskaPredstavaBasic
    {
        public SpecijalnaPredstavaBasic()
        {

        }
        public SpecijalnaPredstavaBasic(int idPredstave, DateTime vreme, int brojKarata) : base(idPredstave, vreme, brojKarata)
        {

        }
    }
}
