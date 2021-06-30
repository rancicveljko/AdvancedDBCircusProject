using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class MestoBoravkaPregled
    {
        public int IdMesta { get; set; }
        public string Grad { get; set; }
        public string Drzava { get; set; }
        public string Opis { get; set; }
        public int Vreme_u_gradu { get; set; }


        public MestoBoravkaPregled()
        {

        }
        public MestoBoravkaPregled(int idmesta, string grad, string drzava, string opis, int vreme)
        {
            this.IdMesta = idmesta;
            this.Grad = grad;
            this.Drzava = drzava;
            this.Opis = opis;
            this.Vreme_u_gradu = vreme;
        }
    }
}
