using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace WindowsFormsApplication1
{
    public partial class AzuriranjeSala : Form
    {
        List<Sala> listaSala;
        string putanja;

        public AzuriranjeSala()
        {
            InitializeComponent();
            listaSala = new List<Sala>();
            putanja = "bazaSala.txt";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(putanja);
            int n, m;
            //ako ne popunis polja;
            if (txtNazivSale.Text.Trim().Length == 0 || txtIdSale.Text.Trim().Length == 0 || txtBrMestaSale.Text.Trim().Length == 0)
            {
                MessageBox.Show("Popunite polja!");
            }
            if (int.TryParse(txtBrMestaSale.Text, out n) == false)
            {
                MessageBox.Show("Pravilno unesite broj mesta u sali!");
            }
            if (int.TryParse(txtIdSale.Text, out m) == false)
            {
                MessageBox.Show("Pravilno unesite id!");
                return;
            }
            //ako postoji putanja i nije prazna
            if (File.Exists(putanja) && f.Length > 0)
            {
                //ovo nauci npmt

                //deserijalizacija
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanja);

                listaSala = bf.Deserialize(fs) as List<Sala>;
                fs.Dispose();
                foreach (Sala sla in listaSala)
                {
                    if (sla.id.Equals(int.Parse(txtIdSale.Text)))
                    {
                        MessageBox.Show("Id vec postoji!");
                        return;
                    }
                    else if (sla.naziv.Equals(txtNazivSale.Text))
                    {
                        MessageBox.Show("Sala vec postoji!");
                        return;
                    }
                }
                listaSala.Add(new Sala(int.Parse(txtIdSale.Text), txtNazivSale.Text, int.Parse(txtBrMestaSale.Text)));

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanja);

                bfSer.Serialize(fsSer, listaSala);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali salu!");
            }
            else
            {
                listaSala.Add(new Sala(int.Parse(txtIdSale.Text), txtNazivSale.Text, int.Parse(txtBrMestaSale.Text)));

                //serijalizacija
                BinaryFormatter bfSer2 = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanja);

                bfSer2.Serialize(fsSer, listaSala);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali salu!"); ;
            }
        }
    }
}

