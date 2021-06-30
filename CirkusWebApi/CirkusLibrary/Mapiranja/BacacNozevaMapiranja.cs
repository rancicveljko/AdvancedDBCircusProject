using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class BacacNozevaMapiranja:SubclassMap<BacacNozeva>
    {
        public BacacNozevaMapiranja()
        {
            Table("BACAC_NOZEVA");

            KeyColumn("ID_PERFORMERA");
            References(x => x.JeZaposleni).Column("ID_ZAPOSLENOG").LazyLoad();//

            //HasMany(x => x.Asistenti).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
