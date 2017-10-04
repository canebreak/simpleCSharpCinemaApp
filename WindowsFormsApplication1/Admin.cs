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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AzuriranjeSala asala = new AzuriranjeSala();
            asala.Show();
            this.Close();
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            AzuriranjeFilma a = new AzuriranjeFilma();

            a.Show();
            this.Close();
        }

        private void updateProjekcija_Click(object sender, EventArgs e)
        {
            AzuriranjeProjekcije aproj = new AzuriranjeProjekcije();
            aproj.Show();
            this.Close();
        }

        private void updateTickets_Click(object sender, EventArgs e)
        {
            AzuriranjeKarte akarte = new AzuriranjeKarte();
            akarte.Show();
            this.Close();
        }

        private void statisticsOfSpace_Click(object sender, EventArgs e)
        {
            StatistikaSale ssale = new StatistikaSale();
            ssale.Show();
            this.Close();
        }
    }
}
