using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Rezervacija : Form
    {
        public Rezervacija()
        {
            InitializeComponent();
        }

        private void btnPrikazProjekcije_Click(object sender, EventArgs e)
        {
            KupovinaKarte kk = new KupovinaKarte();
            kk.Show();
            this.Close();
        }

        private void btnPrikazDetaljaProj_Click(object sender, EventArgs e)
        {
            DetaljiProjekcije dp = new DetaljiProjekcije();
            dp.Show();
            this.Close();
        }

        private void btnOceniProj_Click(object sender, EventArgs e)
        {
            OcenjivanjeProjekcije op = new OcenjivanjeProjekcije();
            op.Show();
            this.Close();
        }
    }
}
