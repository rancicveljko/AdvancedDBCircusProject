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

            List<ZivotinjePregled> listazivotinja = DTOManager.vratiSveZivotinje();
            this.lvSveZivotinje.Items.Clear();

            foreach (ZivotinjePregled zp in listazivotinja)
            {
                ListViewItem item = new ListViewItem(new string[] { zp.IdPerformera.ToString(), zp.UmetnickoIme, zp.Pol, zp.ClanOd.ToString(), zp.Vrsta, zp.Tezina.ToString(), zp.Starost.ToString() });
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
            zivotinja.UmetnickoIme = textBox2.Text;
            if (radioButton1.Checked)
                zivotinja.Pol = radioButton1.Text;
            if (radioButton2.Checked)
                zivotinja.Pol = radioButton2.Text;
            zivotinja.Vrsta = textBox1.Text;
            zivotinja.ClanOd = datum.Value;
            zivotinja.Starost = int.Parse(textBox5.Text);


            DTOManager.dodajZivotinju(zivotinja);



            MessageBox.Show("Uspesno ste dodali novu zivotinju!");

        }
    }
}