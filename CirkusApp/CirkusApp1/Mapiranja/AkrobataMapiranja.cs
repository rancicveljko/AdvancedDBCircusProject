using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class AkrobataMapiranja:SubclassMap<Akrobata>
    {
        public AkrobataMapiranja()
        {
            Table("AKROBATA");

            KeyColumn("ID_PERFORMERA");

            HasManyToMany(x => x.Vestine)
                .Table("JE_VEST_U")
                .ParentKeyColumn("ID_AKROBATE")
                .ChildKeyColumn("ID_VESTINE")
                .Inverse().
                Cascade
                .All();
            
        }
    }
}
