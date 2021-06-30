using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class PredstavaPoNarudzbiniBasic : SpecijalnaPredstavaBasic
    {
        public int BrTelNarucioca { get; set; }
        public string NazivNarucioca { get; set; }
        public string AdresaNarucioca { get; set; }

        public PredstavaPoNarudzbiniBasic()
        {

        }
        public PredstavaPoNarudzbiniBasic(int idPredstave, DateTime vreme, int brojKarata, int brTelNarucioca, string nazivNarucioca, string adresaNarucioca)
            : base(idPredstave, vreme, brojKarata)
        {
            this.BrTelNarucioca = brTelNarucioca;
            this.NazivNarucioca = nazivNarucioca;
            this.AdresaNarucioca = adresaNarucioca;
        }

    }
}

