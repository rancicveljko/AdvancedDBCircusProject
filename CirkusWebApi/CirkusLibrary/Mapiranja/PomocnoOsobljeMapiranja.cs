using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class PomocnoOsobljeMapiranja : SubclassMap<PomocnoOsoblje>
    {
        public PomocnoOsobljeMapiranja()
        {
            Table("POMOCNO_OSOBLJE");

            KeyColumn("ID_ZAPOSLENOG");

            Map(x => x.AsistentFleg, "ASISTENT_FLAG");

            References(x => x.PomazeArtistu).Column("FK_ID_PERFORMERA");

            //References(x => x.RadiSa).Column("FK_ID_PERFORMERA").LazyLoad();
            //References(x => x.Radi_Sa).Column("FK_ID_PERFORMERA").LazyLoad();
            //References(x => x.Radi__Sa).Column("FK_ID_PERFORMERA").LazyLoad();

        }


    }
}
