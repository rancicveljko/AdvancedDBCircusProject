using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class HumanitarnaPredstavaPregled : SpecijalnaPredstavaPregled
    {
        public double Prihod { get; set; }
        public string ZaKoga { get; set; }

        public HumanitarnaPredstavaPregled()
        {

        }
        public HumanitarnaPredstavaPregled(int idPredstave, DateTime vreme, int brojKarata, string mesto, double prihod, string zaKoga) : base(idPredstave, vreme, brojKarata, mesto)
        {
            this.Prihod = prihod;
            this.ZaKoga = zaKoga;
        }
    }
}
