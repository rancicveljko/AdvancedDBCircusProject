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
        public long Maticnibr;
        public virtual DirektorBasic PripadaDirektoru { get; set; }
        public virtual ArtistBasic JeArtist { get; set; }


        public ZaposleniBasic()
        {

        }
        public ZaposleniBasic( string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr)
        {
            
            this.Ime = ime;
            this.Ime_Rod = imer;
            this.Prezime = prez;
            this.Datum_Rodj = datrodj;
            this.Mesto_Rodj = mrodj;
            this.Maticnibr = mbr;


        }
    }
}
