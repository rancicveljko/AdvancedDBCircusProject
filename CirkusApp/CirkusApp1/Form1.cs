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


                MestoBoravka m = new MestoBoravka();

                m.Grad = "Pirot";
                m.Drzava = "Srbija";
                m.Opis = "Lep grad, ponekad";
                m.VremeUGradu = 3;

                s.Save(m);//ID Sekvenca je na 1, a 1-5 vec postoji..

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

                NastupnaTacka nt = new NastupnaTacka();

                nt.Ime = "Elfak studije";
                nt.Tip = "Klovnovski nastup";
                nt.MinGodina = 18;
                nt.OpasniEfekti = 1;


                s.Save(nt);

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
                Akrobata a = s.Get<Akrobata>(6001);

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
