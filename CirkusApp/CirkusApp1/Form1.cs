using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CirkusApp1.Entiteti;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using CirkusApp1.Forme;

namespace CirkusApp1
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                //Prodavnica.Entiteti.Prodavnica p = s.Load<Prodavnica.Entiteti.Prodavnica>(61);
                MestoBoravka m = s.Load<MestoBoravka>(1);

                MessageBox.Show(m.Grad);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajMesto_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Akrobata a = new Akrobata();
                a.JeZaposleni.Ime = "Mika";
                a.JeZaposleni.Ime_Rod = "Vimbldon";
                a.JeZaposleni.Prezime = "Serifovic";
                a.JeZaposleni.Maticnibr = 44444434;
                a.UmetnickoIme = "Smec";
                a.Pol = "Musko";
                a.ClanOd = DateTime.Now;

                Vestina v = new Vestina();
                v.GodinaIskustva = 5;
                v.Naziv = "Sibanje s reket";

                a.JeZaposleni.JeArtist = a;
                
                v.Akrobate.Add(a);
                a.Vestine.Add(v);

                s.Save(a.JeZaposleni);
                s.Save(a);
                s.Save(v);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Dreser d = s.Load<Dreser>(28);

                PomocnoOsoblje po = s.Load<PomocnoOsoblje>(4);


                po.PomazeArtistu = d;
                d.Asistenti.Add(po);


                s.SaveOrUpdate(po);
                s.Update(d);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

  

        private void btnTEST2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                //Prodavnica.Entiteti.Prodavnica p = s.Load<Prodavnica.Entiteti.Prodavnica>(61);
                Akrobata a = s.Load<Akrobata>(23);

                MessageBox.Show(a.Vestine[0].Naziv);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                //ucitavamo podatke o dreseru sa zadatim brojem
                Zivotinja z = s.Load<Zivotinja>(6017);
                MessageBox.Show(z.UmetnickoIme);
                MessageBox.Show(z.DresiraZivotinju.UmetnickoIme);

                s.Close();

            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PocetnaStranica form = new PocetnaStranica();
            form.ShowDialog();
        }
    }
}
