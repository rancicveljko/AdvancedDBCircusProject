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
    public partial class TipArtistaForma : Form
    {
        public TipArtistaForma()
        {
            InitializeComponent();
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
            }
            else if(Dreser.Checked)
            {
                ////kreiramo dresera i ubacujemo id njegov u tabelu dreser
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
