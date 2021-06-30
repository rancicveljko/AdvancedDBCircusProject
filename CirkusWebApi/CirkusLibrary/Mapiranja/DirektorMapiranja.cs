using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using CirkusApp1.Entiteti;

namespace CirkusApp1.Mapiranja
{
	public class DirektorMapiranja : ClassMap<Direktor>
	{

		public DirektorMapiranja()
		{
			Table("DIREKTOR");

			Id(x => x.IdDirektora, "ID_DIREKTORA").GeneratedBy.SequenceIdentity("ISEQ$$_265868");

			Map(x => x.Ime, "IME");
			Map(x => x.Prezime, "PREZIME");
			Map(x => x.Email, "EMAIL");
			Map(x => x.Telefon, "TELEFON");

			HasMany(x => x.Zaposleni).KeyColumn("FK_ID_DIREKTORA").LazyLoad().Cascade.All().Inverse();
		}
	}
}