 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;


namespace CirkusApp1.Mapiranja
{
    public class KlovnMapiranja:SubclassMap<Klovn>
    {
        public KlovnMapiranja()
        {
            Table("KLOVN");

            KeyColumn("ID_PERFORMERA");
            Map(x => x.Tip, "TIP");
            Map(x => x.CimeZabavlja, "CIME_ZABAVLJA"); 

            
        }
    }
}
