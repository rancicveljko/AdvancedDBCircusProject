using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
	public class Direktor
    {
        public virtual int IdDirektora { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Email { get; set; }
        public virtual int Telefon { get; set; }
        public virtual IList<Zaposleni> Zaposleni { get; set; }

        public Direktor()
        {
            Zaposleni = new List<Zaposleni>();
        }
    }
}
