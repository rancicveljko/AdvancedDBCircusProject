using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    class VestinaMapiranja:ClassMap<Vestina>
    {
        public VestinaMapiranja()
        {
            Table("VESTINA");

            Id(x => x.IdVestine, "ID_VESTINE").GeneratedBy.SequenceIdentity("ISEQ$$_265903");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.GodinaIskustva, "GODINA_ISKUSTVA");
            
        }
    }
}
