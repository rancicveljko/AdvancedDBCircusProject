﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    class GutacPlamenaMapiranja:SubclassMap<GutacPlamena>
    {
        public GutacPlamenaMapiranja()
        {
            Table("GUTAC_PLAMENA");

            KeyColumn("ID_PERFORMERA");
        }
    }
}