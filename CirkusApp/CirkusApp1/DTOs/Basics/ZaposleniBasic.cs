using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZaposleniBasic
    {
        public int IdZaposlenog;
        public string Ime;
        public string Ime_Rod;
        public string Prezime;
        public DateTime Datum_Rodj;
        public string Mesto_Rodj;
        public int Maticnibr;


        public ZaposleniBasic()
        {

        }
        public ZaposleniBasic(int Iz, string ime, string imer, string prez, DateTime datrodj, string mrodj, int mbr)
        {
            this.IdZaposlenog = Iz;
            this.Ime = ime;
            this.Ime_Rod = imer;
            this.Prezime = prez;
            this.Datum_Rodj = datrodj;
            this.Mesto_Rodj = mrodj;
            this.Maticnibr = mbr;


        }
    }
}
