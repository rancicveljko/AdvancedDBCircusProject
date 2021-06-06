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

                SpecijalnaPredstava sp = new SpecijalnaPredstava();

                sp.BrojKarata = 30;
                sp.Vreme = DateTime.Now;


                s.Save(sp);

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
                Zaposleni z = s.Get<Zaposleni>(4003);

                MessageBox.Show(z.Ime);

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
    }
}
