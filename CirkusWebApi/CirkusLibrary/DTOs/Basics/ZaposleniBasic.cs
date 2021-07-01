using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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

        //VEZA SA DIREKTOROM IZ ULAZNOG DTO-A
        public int PripadaDirektoruID { get; set; }

        [JsonIgnore]
        public DirektorBasic PripadaDirektoru { get; set; }
        [JsonIgnore]
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
       
    }
}
