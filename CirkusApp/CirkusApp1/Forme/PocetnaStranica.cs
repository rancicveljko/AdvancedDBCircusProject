using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CirkusApp1.Forme;

namespace CirkusApp1
{
    public partial class PocetnaStranica : Form
    {
        public PocetnaStranica()
        {
            InitializeComponent();
        }

        private void btnNastupneTackeForma_Click(object sender, EventArgs e)
        {
            SveNastupneTackeForma form = new SveNastupneTackeForma();
            form.Show();
        }

        private void btnArtistiForma_Click(object sender, EventArgs e)
        {
            SviArtistiForma form = new SviArtistiForma();
            form.Show();
        }
    }
}
