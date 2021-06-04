using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class MestoBoravkaMapiranja : ClassMap<MestoBoravka>
    {
        public MestoBoravkaMapiranja()
        {
            Table("MESTO_BORAVKA");

            Id(x => x.IdMesta, "id_mesta").GeneratedBy.SequenceIdentity("ISEQ$$_265857");

            Map(x => x.Grad, "grad");
            Map(x => x.Drzava, "drzava");
            Map(x => x.Opis, "opis");
            Map(x => x.VremeUGradu, "vreme_u_gradu");


            HasMany(x => x.Predstave).KeyColumn("fk_id_mesta_boravka").LazyLoad().Cascade.All().Inverse();
        }
    }
}
