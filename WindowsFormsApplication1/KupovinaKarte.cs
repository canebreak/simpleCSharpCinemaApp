using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class KupovinaKarte : Form
    {

        List<Karta> listaKarata;
        List<ProdataKarta> listaProdate;
        Karta karta;
        ProdataKarta pKarta;
        string putanjaKarte;
        string putanjaProdate;


        public KupovinaKarte()
        {
            InitializeComponent();
            listaKarata = new List<Karta>();
            listaProdate = new List<ProdataKarta>();
            putanjaKarte = "bazakarta.txt";
            putanjaProdate = "bazaprodatekarte.txt";
        }

        private void KupovinaKarte_Load(object sender, EventArgs e)
        {
            FileInfo k = new FileInfo(putanjaKarte);

            //ako postoji putanja i nije prazna
            if (File.Exists(putanjaKarte) && k.Length > 0)
            {
                //deserijalizacija karata
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaKarte);

                listaKarata = bf.Deserialize(fs) as List<Karta>;
                fs.Dispose();

                foreach (Karta krt in listaKarata)
                {
                    cbProj.Items.Add(krt.film.naziv);
                }
            }
            else
            {
                MessageBox.Show("Karte nisu azurirane!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo k = new FileInfo(putanjaProdate);
            int zbirKarata = 0;
            int n;

            if (txtBrKarata.Text.Trim().Length == 0)
            {
                MessageBox.Show("Popunite polja!");
            }
            if (cbProj.SelectedItem == null)
            {
                MessageBox.Show("Odaberite projekciju!");
                return;
            }
            if (int.TryParse(txtBrKarata.Text, out n) == false)
            {
                MessageBox.Show("Pravilno unesite broj!");
                return;
            }
            if (int.Parse(txtBrKarata.Text) >= 7)
            {
                MessageBox.Show("Mozete kupiti najvise 6 karti!");
            }

            foreach (Karta krt in listaKarata)
            {
                if (cbProj.SelectedItem.ToString().Equals(krt.film.naziv))
                {
                    karta = krt;
                    break;
                }
            }
            if (File.Exists(putanjaProdate) && k.Length > 0)
            {
                //deserijalizacija
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaProdate);

                listaProdate = bf.Deserialize(fs) as List<ProdataKarta>;
                fs.Dispose();
                foreach (ProdataKarta pkrt in listaProdate)
                {
                    if (pkrt.karta.film.naziv.Equals(cbProj.SelectedItem.ToString()))
                    {
                        zbirKarata += pkrt.brKarata;
                    }
                }

                if (zbirKarata >= karta.sediste)
                {
                    MessageBox.Show("Karte su rasprodate");
                    return;
                }

                listaProdate.Add(new ProdataKarta(int.Parse(txtBrKarata.Text), karta));

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaProdate);

                bfSer.Serialize(fsSer, listaProdate);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste kupili kartu!");

            }
            else
            {
                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaProdate);

                listaProdate.Add(new ProdataKarta(int.Parse(txtBrKarata.Text), karta));

                bfSer.Serialize(fsSer, listaProdate);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste kupili kartu!");
            }

        }
    }
}
