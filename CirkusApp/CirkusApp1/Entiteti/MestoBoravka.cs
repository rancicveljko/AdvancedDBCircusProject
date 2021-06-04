using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.Entiteti
{
    public class MestoBoravka
    {
        public virtual int IdMesta { get; protected set; }
        public virtual string Grad { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Opis { get; set; }
        public virtual int VremeUGradu { get; set; }
        public virtual IList<CirkuskaPredstava> Predstave { get; set; } //koristi se IList interface



        public MestoBoravka()
        {
            Predstave = new List<CirkuskaPredstava>();//koristi se List generic klasa
        }
    }
}
