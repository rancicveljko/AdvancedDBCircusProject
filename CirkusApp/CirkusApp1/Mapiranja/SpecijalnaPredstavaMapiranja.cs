using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;
using System.Threading.Tasks;

namespace CirkusApp1.Mapiranja
{
    public class SpecijalnaPredstavaMapiranja : SubclassMap<SpecijalnaPredstava>
    {
        public SpecijalnaPredstavaMapiranja()
        {
            Table("SPECIJALNA_PREDSTAVA");

            KeyColumn("ID_PREDSTAVE");
        }
    }
}
