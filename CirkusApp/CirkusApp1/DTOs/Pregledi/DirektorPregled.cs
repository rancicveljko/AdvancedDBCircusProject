using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Pregledi
{
    public class DirektorPregled
    {

        public int IdDirektora;
        public string Ime;
        public string Prezime;
        public string Email;
        public int Telefon;


        public DirektorPregled(int id, string ime, string prezime, string email, int tel)
        {
            this.IdDirektora = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Telefon = tel;

        }
    }
}
