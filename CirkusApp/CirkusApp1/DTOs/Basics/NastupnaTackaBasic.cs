using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class NastupnaTackaBasic
    {
        public int IdTacke;
        public string Ime;
        public string Tip;
        public int MinGodina;
        public int OpasniEfekti;

        //public virtual CirkuskaPredstavaBasic Predstava { get; set; }
        public NastupnaTackaBasic()
        {

        }
        public NastupnaTackaBasic(int IdTacke, string Ime, string Tip, int minGodina, int OpasniEfekti)
        {
            this.IdTacke = IdTacke;
            this.Ime = Ime;
            this.Tip = Tip;
            this.MinGodina = minGodina;
            this.OpasniEfekti = OpasniEfekti;
        }
    }
}
