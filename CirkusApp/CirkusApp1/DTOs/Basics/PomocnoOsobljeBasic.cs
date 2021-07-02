using CirkusApp1.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class PomocnoOsobljeBasic : ZaposleniBasic
    {
        public int PomazeArtistuID { get; set; }
        public Boolean AsistentFleg { get; set; }
        public ArtistBasic PomazeArtistu { get; set; }
        public DreserBasic RadiSaDreserom { get; set; }
        public BacacNozevaBasic RadiSaBacacemNozeva { get; set; }
        public GutacPlamenaBasic RadiSaGutacemPlamena { get; set; }

        public PomocnoOsobljeBasic()
        {

        }

        public PomocnoOsobljeBasic(int id, string ime, string imer, string prez, DateTime datrodj, string mrodj, long mbr, Boolean asistent) : base(id, ime, imer, prez, datrodj, mrodj, mbr)
        {
            this.AsistentFleg = asistent;
        }
        public PomocnoOsobljeBasic(PomocnoOsoblje pom):base(pom)
        {
            this.AsistentFleg = pom.AsistentFleg;
        }
    }
}
