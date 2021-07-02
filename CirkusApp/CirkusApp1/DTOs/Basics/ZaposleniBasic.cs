using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class ZaposleniBasic
    {
        public int IdZaposlenog { get; set; }
        public string Ime { get; set; }
        public string Ime_Rod { get; set; }
        public string Prezime { get; set; }
        public DateTime Datum_Rodj { get; set; }
        public string Mesto_Rodj { get; set; }
        public long Maticnibr { get; set; }

        public int PripadaDirektoruID { get; set; }

        public DirektorBasic PripadaDirektoru { get; set; }
        public ArtistBasic JeArtist { get; set; }


        public ZaposleniBasic()
        {

        }
        public ZaposleniBasic(int Iz, string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr)
        {
            this.IdZaposlenog = Iz;
            this.Ime = ime;
            this.Ime_Rod = imer;
            this.Prezime = prez;
            this.Datum_Rodj = datrodj;
            this.Mesto_Rodj = mrodj;
            this.Maticnibr = mbr;
        }
        public ZaposleniBasic(Zaposleni zap)
        {
            this.IdZaposlenog = zap.IdZaposlenog;
            this.Ime = zap.Ime;
            this.Ime_Rod = zap.Ime_Rod;
            this.Prezime = zap.Prezime;
            this.Datum_Rodj = zap.Datum_Rodj;
            this.Mesto_Rodj = zap.Mesto_Rodj;
            this.Maticnibr = zap.Maticnibr;
        }

    }
}
