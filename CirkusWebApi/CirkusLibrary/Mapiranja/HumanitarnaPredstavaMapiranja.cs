using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class HumanitarnaPredstavaMapiranja : SubclassMap<HumanitarnaPredstava>
    {
        public HumanitarnaPredstavaMapiranja()
        {
            Table("HUMANITARNA_PREDSTAVA");

            KeyColumn("ID_PREDSTAVE");

            Map(x => x.Prihod).Column("PRIHOD");
            Map(x => x.ZaKoga).Column("ZA_KOGA");
        }
    }
}
