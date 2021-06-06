using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class Zaposleni
    {
        public virtual int IdZaposlenog { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Ime_Rod { get; set; }
        public virtual string Prezime { get; set; }
        public virtual DateTime Datum_Rodj { get; set; }
        public virtual string Mesto_Rodj { get; set; }
        public virtual long Maticnibr { get; set; }
        public virtual Direktor PripadaDirektoru { get; set; }
        public virtual Artist JeArtist { get; set; }

        public Zaposleni()
        {

        }
    }
}

