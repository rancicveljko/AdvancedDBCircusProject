using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class PomocnoOsobljeBasic : ZaposleniBasic
    {
        public int PomazeArtistuID { get; set; }
        public Boolean AsistentFleg { get; set; }
        [JsonIgnore]
        public ArtistBasic PomazeArtistu { get; set; }

        [JsonIgnore]
        public DreserBasic RadiSaDreserom { get; set; }
        [JsonIgnore]
        public BacacNozevaBasic RadiSaBacacemNozeva { get; set; }
        [JsonIgnore]
        public GutacPlamenaBasic RadiSaGutacemPlamena { get; set; }

        public PomocnoOsobljeBasic()
        {

        }

        public PomocnoOsobljeBasic(int id, string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr, Boolean asistent) : base(id, ime, imer, prez, datrodj, mrodj, mbr)
        {
            this.AsistentFleg = asistent;
        }
    }
}
