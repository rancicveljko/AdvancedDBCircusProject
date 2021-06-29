using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class MestoBoravkaPregled
    {
        public int IdMesta;
        public string Grad;
        public string Drzava;
        public string Opis;
        public int Vreme_u_gradu;


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
