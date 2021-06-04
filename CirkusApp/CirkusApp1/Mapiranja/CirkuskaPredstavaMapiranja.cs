using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class CirkuskaPredstavaMapiranja : ClassMap<CirkuskaPredstava>
    {
        public CirkuskaPredstavaMapiranja()
        {
            Table("CIRKUSKA_PREDSTAVA");

            Id(x => x.IdPredstave, "id_predstave").GeneratedBy.SequenceIdentity("ISEQ$$_265871");

            Map(x => x.Vreme, "vreme");
            Map(x => x.BrojKarata, "broj_karata");

            References(x => x.Mesto).Column("fk_id_mesta_boravka").LazyLoad();

            HasMany(x => x.Tacke).KeyColumn("fk_id_predstave").LazyLoad().Cascade.All().Inverse();
        }


    }
}
