using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CirkusApp1.DTOs.Pregledi;
using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using NHibernate.Exceptions;

namespace CirkusApp1.Forme
{
    public partial class DodavanjeZaposlenog : Form
    {
        int brojZaposlenih = 0;

        public DodavanjeZaposlenog()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;

            List<DirektorPregled> listaDirektora = DTOManager.vratiSveDirektore();
            this.lvSviDirektori.Items.Clear();

            foreach (DirektorPregled dir in listaDirektora)
            {
                ListViewItem item = new ListViewItem(new string[] { dir.IdDirektora.ToString(), dir.Ime, dir.Prezime,dir.Email,dir.Telefon.ToString()});
                this.lvSviDirektori.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSviDirektori.Refresh();
        }
        private void DodavanjeZaposlenog_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void DodajZaposlenog_Click(object sender, EventArgs e)
        {
            if (lvSviDirektori.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Direktora koji zaposljava novog zaposlenog!");
                return;
            }

            int idDirektora = Int32.Parse(lvSviDirektori.SelectedItems[0].SubItems[0].Text);
            DirektorBasic p = DTOManager.vratiDirektora(idDirektora);

            ZaposleniBasic radnik = new ZaposleniBasic();

            radnik.Ime = textBox1.Text;
            radnik.Ime_Rod = textBox2.Text;
            radnik.Prezime = textBox3.Text;
            radnik.Datum_Rodj = datumRodjenja.Value;
            radnik.Mesto_Rodj = textBox5.Text;
            radnik.Maticnibr = Int64.Parse(textBox6.Text);

            radnik.PripadaDirektoru = p;

            DTOManager.dodajZaposlenog(radnik);



            MessageBox.Show("Uspesno ste dodali novog zaposlenog!");
            DodajArtistaForma forma = new DodajArtistaForma(radnik);
            forma.Show();
        }
    }
}
