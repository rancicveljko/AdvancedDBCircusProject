using CirkusApp1.DTOManagers;
using CirkusApp1.DTOs.Basics;
using CirkusApp1.DTOs.Pregledi;
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
    public partial class DodajNastupnuTacku : Form
    {
        int brojZaposlenih = 0;
        public DodajNastupnuTacku()
        {
            InitializeComponent();
        }
        public void popuniPodacima()
        {
            this.brojZaposlenih = 0;

            List<CirkuskaPredstavaPregled> listaPredstava = DTOManager.vratiSveCirkuskePredstave();
            this.lvSvePredstave.Items.Clear();

            foreach (CirkuskaPredstavaPregled dir in listaPredstava)
            {
                ListViewItem item = new ListViewItem(new string[] { dir.IdPredstave.ToString(), dir.Vreme.ToString(), dir.BrojKarata.ToString() });
                this.lvSvePredstave.Items.Add(item);
                //this.brojProizvoda++;
            }

            //txbBrojProizvoda.Text = this.brojProizvoda.ToString();
            this.lvSvePredstave.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Trim() == string.Empty) || (textBox2.Text.Trim() == string.Empty) || (textBox3.Text.Trim() == string.Empty) || (textBox4.Text.Trim() == string.Empty))
            {
                MessageBox.Show("Popunite sva polja!!!!!!");
                return;
            }

            if (lvSvePredstave.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Predstavu u kojoj se nalazi nastupna tacka!");
                return;
            }
            int idPredstave = Int32.Parse(lvSvePredstave.SelectedItems[0].SubItems[0].Text);
            CirkuskaPredstavaBasic p = DTOManager.vratiCirkuskuPredstavuBasic(idPredstave);

            NastupnaTackaBasic radnik = new NastupnaTackaBasic();

            radnik.Ime = textBox1.Text;
            radnik.Tip = textBox2.Text;
            radnik.MinGodina = Int32.Parse(textBox3.Text);
            radnik.OpasniEfekti = Int32.Parse(textBox4.Text);
            

            radnik.Predstava = p;

            DTOManager.dodajNastupnuTacku(radnik);



            MessageBox.Show("Uspesno ste dodali novu nastupnu tacku !");
        }

        private void DodajNastupnuTacku_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lvSvePredstave.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Predstavu koju zelite da obrisete!");
                return;
            }
            int idPredstave = Int32.Parse(lvSvePredstave.SelectedItems[0].SubItems[0].Text);
            DTOManager.obrisiCirkuskuPredstavu(idPredstave);
            MessageBox.Show("Uspesno ste obrisali predstavu!");
        }
    }
}
