using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CirkusApp1.Forme
{
    public partial class DodajArtistaForma : Form
    {
        public ZaposleniBasic zaposlen;
        public DodajArtistaForma()
        {
            InitializeComponent();
        }
        public DodajArtistaForma(ZaposleniBasic z)
        {
            InitializeComponent();
            zaposlen = z;

        }

        private void IzaberiTip_Click(object sender, EventArgs e)
        {
            if (Klovn.Checked)
            {
                DodajKlovnaForma forma = new DodajKlovnaForma();
                forma.ShowDialog();
            }
            else if(Zongler.Checked)
            {
                DodajZongleraForma forma = new DodajZongleraForma();
                forma.ShowDialog();
            }
            else if(Akrobata.Checked)
            {
                //kreiramo akrobatu i ubacujemo id njegov u tabelu akrobata
                AkrobataBasic akrobata = new AkrobataBasic();

                akrobata.UmetnickoIme = textBox1.Text;
                akrobata.Pol = textBox2.Text;
                akrobata.ClanOd = clanOd.Value;

                akrobata.Zaposleni = zaposlen;

                DTOManager.dodajAkrobatu(akrobata);

                MessageBox.Show("Uspesno ste dodali novog Akrobatu!");
            }
            else if(Dreser.Checked)
            {
                DreserBasic dreser = new DreserBasic();

                dreser.UmetnickoIme = textBox1.Text;
                dreser.Pol = textBox2.Text;
                dreser.ClanOd = clanOd.Value;

                dreser.Zaposleni = zaposlen;

                DTOManager.dodajDresera(dreser);

                MessageBox.Show("Uspesno ste dodali novog Dresera!");
            }
            else if(BacacNozeva.Checked)
            {
                //kreiramo bacaca i ubacujemo id njegov u tabelu bacac plamena
            }
            else if (GutacPlamena.Checked)
            {
                //kreiramo gutaca i ubacujemo id njegov u tabelu gutac plamena
            }





        }
    }
}
