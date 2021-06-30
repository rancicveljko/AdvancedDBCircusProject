using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class HumanitarnaPredstavaBasic : SpecijalnaPredstavaBasic
    {
        public double Prihod { get; set; }
        public string ZaKoga { get; set; }

        public HumanitarnaPredstavaBasic()
        {

        }
        public HumanitarnaPredstavaBasic(int idPredstave, DateTime vreme, int brojKarata, double prihod, string zaKoga) : base(idPredstave, vreme, brojKarata)
        {
            this.Prihod = prihod;
            this.ZaKoga = zaKoga;
        }
    }
}
