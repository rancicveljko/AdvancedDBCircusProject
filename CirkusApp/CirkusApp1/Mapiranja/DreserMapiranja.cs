﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
    public class DreserMapiranja:SubclassMap<Dreser>
    {
        public DreserMapiranja()
        {
            Table("DRESER");

            KeyColumn("ID_PERFORMERA");
            References(x => x.JeZaposleni).Column("ID_ZAPOSLENOG").LazyLoad();//

            HasMany(x => x.Zivotinje).KeyColumn("ID_PERFORMERA").LazyLoad().Cascade.All().Inverse();
            // HasMany(x => x.Asistenti).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }

    }
}
