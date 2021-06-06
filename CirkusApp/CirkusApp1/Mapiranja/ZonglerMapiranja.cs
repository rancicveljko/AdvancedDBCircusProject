using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class ZonglerMapiranja:SubclassMap<Zongler>
    {
        public ZonglerMapiranja()
        {
            Table("ZONGLER");

            KeyColumn("ID_PERFORMERA");
            Map(x => x.NazivPredmeta, "NAZIV_PREDMETA");
            Map(x => x.MaxPredmeta, "MAX_PREDMETA");
        }
    }
}
