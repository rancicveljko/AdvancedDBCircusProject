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

namespace CirkusApp1.Forme
{
    public partial class ZivotinjeForma : Form
    {
        int brojzivotinja = 0;

        public ZivotinjeForma()
        {
            InitializeComponent();
        }

        private void ZivotinjeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.brojzivotinja = 0;

            List<ZivotinjePregled> listazivotinja = DTOManager.vratiSveZivotinje();
            this.lvSveZivotinje.Items.Clear();

            foreach (ZivotinjePregled zp in listazivotinja)
            {
                ListViewItem item = new ListViewItem(new string[] { zp.IdPerformera.ToString(), zp.UmetnickoIme, zp.Vrsta, zp.Pol, zp.Starost.ToString() });
                this.lvSveZivotinje.Items.Add(item);
                //this.brojZivotinja++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSveZivotinje.Refresh();
        }

        private void btnObrisiZivotinju_Click(object sender, EventArgs e)
        {
            if (lvSveZivotinje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da obrisete!");
                return;
            }

            int idZivotinje = Int32.Parse(lvSveZivotinje.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu zivotinju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiZivotinju(idZivotinje);
                MessageBox.Show("Brisanje zivotinje je uspesno obavljeno!");
                this.popuniPodacima();
            }
        }

        private void btnDodajZivotinju_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prvo morate dodati novog Zaposlenog!");
            DodajZivotinjuForma forma = new DodajZivotinjuForma();
            forma.Show();
        }

        private void btnIzmeniZivotinju_Click(object sender, EventArgs e)
        {

            if (lvSveZivotinje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da izmenite!");
                return;
            }

            int idZivotinje = Int32.Parse(lvSveZivotinje.SelectedItems[0].SubItems[0].Text);
            ZivotinjaBasic z = DTOManager.vratiZivotinju(idZivotinje);
            IzmeniZivotinjuForma forma = new IzmeniZivotinjuForma();
            forma.ShowDialog();
            popuniPodacima();
        }

        private void ZivotinjeForma_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnDodajZivotinju_Click_1(object sender, EventArgs e)
        {
            DodajZivotinjuForma forma = new DodajZivotinjuForma();
            forma.Show();
        }

        private void btnIzmeniZivotinju_Click_1(object sender, EventArgs e)
        {
            IzmeniZivotinjuForma forma = new IzmeniZivotinjuForma();
            forma.Show();
        }
    }
}
