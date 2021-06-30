using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class PredstavaPoNarudzbiniMapiranja : SubclassMap<PredstavaPoNarudzbini>
    {
        public PredstavaPoNarudzbiniMapiranja()
        {
            Table("PREDSTAVA_PO_NARUDZBINI");

            KeyColumn("ID_PREDSTAVE");

            Map(x => x.BrTelNarucioca).Column("BR_TEL_NARUCIOCA");
            Map(x => x.NazivNarucioca).Column("NAZIV_NARUCIOCA");
            Map(x => x.AdresaNarucioca).Column("ADRESA_NARUCIOCA");
        }
    }
}
