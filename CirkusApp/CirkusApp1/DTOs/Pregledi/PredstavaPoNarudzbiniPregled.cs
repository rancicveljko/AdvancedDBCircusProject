using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
   public class PredstavaPoNarudzbiniPregled : SpecijalnaPredstavaPregled
    {
        public int BrTelNarucioca { get; set; }
        public string NazivNarucioca { get; set; }
        public string AdresaNarucioca { get; set; }

        public PredstavaPoNarudzbiniPregled()
        {

        }
        public PredstavaPoNarudzbiniPregled(int idPredstave, DateTime vreme, int brojKarata, int brTelNarucioca, string nazivNarucioca, string adresaNarucioca)
            : base(idPredstave, vreme, brojKarata)
        {
            this.BrTelNarucioca = brTelNarucioca;
            this.NazivNarucioca = nazivNarucioca;
            this.AdresaNarucioca = adresaNarucioca;
        }
    }
}
