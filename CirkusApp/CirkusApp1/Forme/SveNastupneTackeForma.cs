using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CirkusApp1.DTOs.Basics;
using CirkusApp1.DTOs.Pregledi;
using CirkusApp1.DTOManagers;

namespace CirkusApp1.Forme
{
    public partial class SveNastupneTackeForma : Form
    {
        int brojProizvoda = 0;

        public SveNastupneTackeForma()
        {
            InitializeComponent();
        }

        private void SveNastupneTackeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brojProizvoda = 0;

            List<NastupnaTackaPregled> listaTacaka = DTOManager.vratiSveNastupneTacke();
            this.lvSveNastupneTacke.Items.Clear();

            foreach (NastupnaTackaPregled ntp in listaTacaka)
            {
                ListViewItem item = new ListViewItem(new string[] { ntp.IdTacke.ToString(), ntp.Ime, ntp.Tip, ntp.MinGodina.ToString(), ntp.OpasniEfekti.ToString() });
                this.lvSveNastupneTacke.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSveNastupneTacke.Refresh();
        }

        private void btnObrisiNastupnuTacku_Click(object sender, EventArgs e)
        {
            if (lvSveNastupneTacke.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nastupnu tacku koju zelite da obrisete!");
                return;
            }

            int idProizvoda = Int32.Parse(lvSveNastupneTacke.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu nastupnu tacku?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiNastupnuTacku(idProizvoda);
                MessageBox.Show("Brisanje je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnDodajNastupnuTacku_Click(object sender, EventArgs e)
        {
            
        }
    }
}
