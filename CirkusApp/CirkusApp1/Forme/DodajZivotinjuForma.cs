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
    public partial class DodajZivotinjuForma : Form
    {
        int brojzivotinja = 0;
        public DodajZivotinjuForma()
        {
            InitializeComponent();
        }

        public void popuniPodacima()
        {
            this.brojzivotinja = 0;

            List<DreserPregled> listaDresera = DTOManager.vratiDresere();
            this.lvSveZivotinje.Items.Clear();

            foreach (DreserPregled zp in listaDresera)
            {
                ListViewItem item = new ListViewItem(new string[] { zp.ArtistId.ToString(), zp.UmetnickoIme });
                this.lvSveZivotinje.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSveZivotinje.Refresh();
        }
        private void DodavanjeZivotinje_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void DodajZivotinju_Click(object sender, EventArgs e)
        {


            ZivotinjaBasic zivotinja = new ZivotinjaBasic();
            zivotinja.UmetnickoIme = tbUmIme.Text;
            zivotinja.Pol =
            zivotinja.Vrsta = tbVrsta.Text;
            zivotinja.ClanOd = datum.Value;
            zivotinja.Starost = int.Parse(tbStarost.Text);

            if (lvSveZivotinje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zivotinju koju zelite da obrisete!");
                return;
            }
            var dreserID = Int32.Parse(lvSveZivotinje.SelectedItems[0].SubItems[0].Text);
            var dreser = DTOManager.vratiDresera(dreserID);

            zivotinja.DresiraZivotinju = dreser;
            //dreser.Zivotinje.Add(zivotinja);

            DTOManager.dodajZivotinju(zivotinja);



            MessageBox.Show("Uspesno ste dodali novu zivotinju!");

        }



        private void DodajZivotinju_Click_1(object sender, EventArgs e)
        {
            if (tbUmIme.Text.Equals(String.Empty) || (rbMusko.Checked == false && rbZensko.Checked == false) || tbVrsta.Text.Equals(String.Empty) || tbTezina.Text.Equals(String.Empty) || tbStarost.Text.Equals(String.Empty))
            {
                MessageBox.Show("Moraju sva polja da se popune");
                return;
            }

            DodajZivotinju_Click(sender, e);
        }

        private void DodajZivotinjuForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}