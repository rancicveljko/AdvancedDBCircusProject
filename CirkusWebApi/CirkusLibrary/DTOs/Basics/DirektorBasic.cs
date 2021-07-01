using System;
using CirkusApp1.Entiteti;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusApp1.DTOs.Basics
{
    public class DirektorBasic
    {
        public int IdDirektora { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }


        public IList<ZaposleniBasic> Zaposleni { get; set; }

        public DirektorBasic()
        {
            Zaposleni = new List<ZaposleniBasic>();

        }

        public DirektorBasic(int id, string ime, string prezime, string email, int tel)
        {
            this.IdDirektora = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Telefon = tel;

            Zaposleni = new List<ZaposleniBasic>();
        }

        public DirektorBasic(Direktor d)
        {
            this.IdDirektora = d.IdDirektora;
            this.Ime = d.Ime;
            this.Prezime = d.Prezime;
            this.Email = d.Email;
            this.Telefon = d.Telefon;
        }
        public override string ToString()
        {
            return Ime + " " + Prezime + " " + Email;
        }

    }
}
