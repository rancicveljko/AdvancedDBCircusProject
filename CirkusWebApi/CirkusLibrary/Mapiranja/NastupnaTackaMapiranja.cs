using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class NastupnaTackaMapiranja :  ClassMap<NastupnaTacka>
    {
        public NastupnaTackaMapiranja()
        {
            Table("NASTUPNA_TACKA");

            Id(x => x.IdTacke, "id_tacke").GeneratedBy.SequenceIdentity("ISEQ$$_265878");

            Map(x => x.Ime, "ime");
            Map(x => x.Tip, "tip");
            Map(x => x.MinGodina, "min_godina");
            Map(x => x.OpasniEfekti, "opasni_efekti");

            References(x => x.Predstava).Column("fk_id_predstave").LazyLoad();
        }
    }
}
