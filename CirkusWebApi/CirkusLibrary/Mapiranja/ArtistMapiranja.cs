using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class ArtistMapiranja:ClassMap<Artist>
    {
        public ArtistMapiranja()
        {
            Table("ARTIST");

            Id(x => x.IdPerformera, "ID_PERFORMERA").GeneratedBy.SequenceIdentity("ISEQ$$_265885");

            
            Map(x => x.UmetnickoIme, "UMETNICKO_IME");
            Map(x => x.Pol, "POL");
            Map(x => x.ClanOd, "CLAN_OD");

            References(x => x.JeZaposleni).Column("ID_ZAPOSLENOG").Unique().LazyLoad();
        }
    }
}
