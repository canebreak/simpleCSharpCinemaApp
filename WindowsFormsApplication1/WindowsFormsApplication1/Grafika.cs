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
    public partial class Grafika : Form
    {
        double procenatPopunjnosti;
        public Grafika(double procenat)
        {
            InitializeComponent();
            this.procenatPopunjnosti = procenat;
        }

        private void Grafika_Load(object sender, EventArgs e)
        {
            label1.Text = "Popunjenost sale: " + procenatPopunjnosti.ToString() + "%";
        }
    }
}
