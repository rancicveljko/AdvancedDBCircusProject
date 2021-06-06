using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class NastupnaTackaPregled
    {
        public int IdTacke;
        public string Ime;
        public string Tip;
        public int MinGodina;
        public int OpasniEfekti;

        public NastupnaTackaPregled()
        {

        }
        public NastupnaTackaPregled(int IdTacke, string Ime, string Tip, int minGodina, int OpasniEfekti)
        {
            this.IdTacke = IdTacke;
            this.Ime = Ime;
            this.Tip = Tip;
            this.MinGodina = minGodina;
            this.OpasniEfekti = OpasniEfekti;
        }

    }
}
