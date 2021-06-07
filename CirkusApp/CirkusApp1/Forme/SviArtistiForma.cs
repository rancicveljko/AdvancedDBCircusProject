using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Pregledi;
using CirkusApp1.Entiteti;
using NHibernate;
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
    public partial class SviArtistiForma : Form
    {
        private int brojProizvoda=0;
        public SviArtistiForma()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {
            this.brojProizvoda = 0;

            List<ArtistPregled> listaTacaka = DTOManager.vratiSveArtiste();
            this.lvSviArtisti.Items.Clear();

            foreach (ArtistPregled art in listaTacaka)
            {
                ListViewItem item = new ListViewItem(new string[] { art.ArtistId.ToString(), art.UmetnickoIme, art.Pol});
                this.lvSviArtisti.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSviArtisti.Refresh();
        }

        private void btnDodajArtista_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zaposleni z = new Zaposleni();
                z.Ime = "Stojan";
                z.Ime_Rod = "Mirko";
                z.Prezime = "Rodoljubovic";
                z.Maticnibr = 789132789;

                s.Save(z);

                Artist a = new Artist();
                a.UmetnickoIme = "asdjnosadon";
                a.Pol = "Ne znam";
                a.ClanOd = DateTime.Now;
                a.JeZaposleni = z;

                z.JeArtist = a;

                s.Save(a);

                s.Flush();

                popuniPodacima();
                lvSviArtisti.Refresh();

                s.Close();
            }
            catch(Exception ex)
            {
                //exception ce da handluje uskoro!
            }

        }

        private void btnObrisiArtista_Click(object sender, EventArgs e)
        {
            if (lvSviArtisti.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite artista kog zelite da obrisete!");
                return;
            }

            int idProizvoda = Int32.Parse(lvSviArtisti.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog artista?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                //DTOManager.obrisiArtista(idProizvoda);
                MessageBox.Show("Brisanje je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void SviArtistiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
