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

namespace CirkusApp1.Forme
{
    public partial class SviArtistiForma : Form
    {
        int brojartista = 0;
        public SviArtistiForma()
        {
            InitializeComponent();
        }



        public void popuniPodacima()
        {
            this.brojartista = 0;

            List<ArtistPregled> listaArtista = DTOManager.vratiSveArtiste();
            this.lvSviArtisti.Items.Clear();

            foreach (ArtistPregled art in listaArtista)
            {
                ListViewItem item = new ListViewItem(new string[] { art.ArtistId.ToString(), art.UmetnickoIme, art.Pol});
                this.lvSviArtisti.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSviArtisti.Refresh();
        }

        private void SviArtistiForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void ObrisiArtista_Click(object sender, EventArgs e)
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
                DTOManager.obrisiNastupnuTacku(idProizvoda);
                MessageBox.Show("Brisanje artista je uspesno obavljeno!");
                this.popuniPodacima();
            }

        }

        private void btnDodajArtista_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prvo morate dodati novog Zaposlenog!");
            DodavanjeZaposlenog forma = new DodavanjeZaposlenog();
            forma.Show();
        }
    }
}
