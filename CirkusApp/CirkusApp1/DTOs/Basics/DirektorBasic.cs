using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class DirektorBasic
    {
        public int IdDirektora;
        public string Ime;
        public string Prezime;
        public string Email;
        public int Telefon;


        public IList<ZaposleniBasic> Zaposleni { get; set; }

        public DirektorBasic()
        {
            Zaposleni = new List<ZaposleniBasic>();

        }

        public DirektorBasic( string ime, string prezime, string email, int tel)
        {
            
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Telefon = tel;

            Zaposleni = new List<ZaposleniBasic>();
        }
        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Email;
        }

    }
}
