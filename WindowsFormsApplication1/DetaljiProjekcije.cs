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
    public partial class DetaljiProjekcije : Form
    {

        List<Projekcija> listaProjekcije;
        List<Film> listaOcena;
        string putanjaProjekcije;
        string putanjaOcena;

        public DetaljiProjekcije()
        {
            InitializeComponent();
            listaProjekcije = new List<Projekcija>();
            listaOcena = new List<Film>();
            putanjaProjekcije = "bazaprojekcije.txt";
            putanjaOcena = "bazaocena.txt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetaljiProjekcije_Load(object sender, EventArgs e)
        {
            //da se labele ne vide pre klika na dugme
            nazivFilma.Visible = false;
            opis.Visible = false;
            zanr.Visible = false;
            ocena.Visible = false;

            FileInfo f = new FileInfo(putanjaProjekcije);

            //ako postoji putanja i nije prazna
            if (File.Exists(putanjaProjekcije) && f.Length > 0)
            {
                //deserijalizacija projekcija
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaProjekcije);

                listaProjekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Dispose();

                foreach (Projekcija pro in listaProjekcije)
                {
                    cbProjekcije.Items.Add(pro.film.naziv);
                }
            }
            else
            {
                MessageBox.Show("Projekcije nisu azurirane!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo k = new FileInfo(putanjaOcena);
            int brojac = 0;
            double prosek = 0;
            double zbir = 0;

            if (cbProjekcije.SelectedItem == null)
            {
                MessageBox.Show("Odaberite projekciju!");
                return;
            }
            //da se labele prikaazu
            nazivFilma.Visible = true;
            opis.Visible = true;
            zanr.Visible = true;
            ocena.Visible = true;

            if (File.Exists(putanjaOcena) && k.Length > 0)
            {
                //deserijalizacija ocena
                BinaryFormatter bf1 = new BinaryFormatter();
                FileStream fs1 = File.OpenRead(putanjaOcena);

                listaOcena = bf1.Deserialize(fs1) as List<Film>;
                fs1.Dispose();

                foreach (Film flm in listaOcena)
                {
                    if (cbProjekcije.SelectedItem.ToString().Equals(flm.naziv))
                    {
                        brojac++;
                        zbir += flm.ocena;
                    }
                }

            }
            else
            {
                ocena.Text = "nije ocenjen";
            }



            //postavljanje texta labelama
            foreach (Projekcija pro in listaProjekcije)
            {
                if (cbProjekcije.SelectedItem.ToString().Equals(pro.film.naziv))
                {
                    prosek = zbir / brojac;
                    if (prosek == 0.0) { ocena.Text = "nije ocenjen"; }
                    ocena.Text = Math.Round(prosek, 1).ToString();
                    nazivFilma.Text = pro.film.naziv;
                    opis.Text = pro.film.opis;
                    zanr.Text = pro.film.zanr;
                }
            }
        }
    }
}
