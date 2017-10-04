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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();
        }

        private void rez_Click(object sender, EventArgs e)
        {
            Rezervacija r = new Rezervacija();
            r.Show();
        }
    }
}
