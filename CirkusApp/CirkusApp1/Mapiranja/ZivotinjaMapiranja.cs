using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;


namespace CirkusApp1.Mapiranja
{
    public class ZivotinjaMapiranja:ClassMap<Zivotinja>
    {
        public ZivotinjaMapiranja()
        {
            Table("ZIVOTINJA");

            Id(x => x.IdPerformera, "ID_PERFORMERA").GeneratedBy.SequenceIdentity("ISEQ$$_265912");

            Map(x => x.UmetnickoIme, "UMETNICKO_IME");
            Map(x => x.Pol, "POL");
            Map(x => x.ClanOd, "CLAN_OD");
            Map(x => x.Vrsta, "VRSTA");
            Map(x => x.ZadnjiPregled, "ZADNJI_PREGLED");
            Map(x => x.Tezina, "TEZINA");
            Map(x => x.BrojKaveza, "BROJ_KAVEZA");
            Map(x => x.Starost, "STAROST");

            //Mapiranje veze 1:N Dreser-Zivotinja
            References(x => x.DresiraZivotinju).Column("FK_ID_DRESERA").LazyLoad();
        }
    }
}
