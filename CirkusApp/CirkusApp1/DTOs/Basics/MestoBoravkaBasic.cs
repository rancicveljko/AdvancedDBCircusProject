using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class MestoBoravkaBasic
    {
        public int IdMesta;
        public string Grad;
        public string Drzava;
        public string Opis;
        public int Vreme_u_gradu;
        //public virtual IList<CirkuskaPredstavaBasic> Predstave { get; set; }

        public MestoBoravkaBasic()
        {
            //inicijalizacija liste Predstave
        }
        public MestoBoravkaBasic(int idmesta, string grad, string drzava, string opis, int vreme)
        {
            this.IdMesta = idmesta;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Opis = opis;
            this.Vreme_u_gradu = vreme;
        }
    }
}
