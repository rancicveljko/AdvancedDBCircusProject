using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.IdPredstave, "id_predstave").GeneratedBy.SequenceIdentity("ISEQ$$_265871");

            Map(x => x.Ime, "IME");
            Map(x => x.Ime_Rod, "IME_ROD");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Datum_Rodj, "DATUM_RODJ");
            Map(x => x.Mesto_Rodj, "MESTO_RODJ");
            Map(x => x.Maticnibr, "MAT_BR");
            

            References(x => x.IdDirektora).Column("FK_ID_DIREKTORA").LazyLoad();

        }


    }
}
