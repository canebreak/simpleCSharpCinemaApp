using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class AzuriranjeKarte : Form
    {
        List<Karta> listaKarta;
        List<Projekcija> listaProjekcija;
        Projekcija projekcija;
        string putanjaKarta;
        string putanjaProjekcija;
        public AzuriranjeKarte()
        {
            InitializeComponent();
            listaKarta = new List<Karta>();
            listaProjekcija = new List<Projekcija>();
            putanjaKarta = "bazakarta.txt";
            putanjaProjekcija = "bazaprojekcije.txt";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(putanjaKarta);
            FileInfo p = new FileInfo(putanjaProjekcija);
            int n, m;
            bool ima = false;

            if (nazivProj.Text.Trim().Length == 0 || idKarte.Text.Trim().Length == 0 || cena.Text.Trim().Length == 0)
            {
                MessageBox.Show("Popunite sva polja!");
                return;
            }
            if (int.TryParse(sediste.Text, out n) == false)
            {
                MessageBox.Show("Pravilno unesite broj sedista!");
                return;
            }
            if (int.TryParse(cena.Text, out m) == false)
            {
                MessageBox.Show("Pravilno unesite cenu!");
                return;
            }
            //sve ovo ispod izvlaci film i salu ako su dodati,a ako ne izbacuje gresku da treba prvo da se dodaju sala i film


            if (File.Exists(putanjaProjekcija) && p.Length > 0)
            {
                //deserijalizacija projekcije
                BinaryFormatter bfP = new BinaryFormatter();
                FileStream fsP = File.OpenRead(putanjaProjekcija);

                listaProjekcija = bfP.Deserialize(fsP) as List<Projekcija>;
                fsP.Dispose();
            }
            else
            {
                MessageBox.Show("Niste dodali projekciju");
                return;
            }

            foreach (Projekcija pro in listaProjekcija)
            {
                //ako je film razlicit od onog unetog u txtNazivFilma prikazi poruku,a ako je isti projekcija  = pro
                if (pro.film.naziv.Equals(nazivProj.Text))
                {
                    projekcija = pro;
                    ima = true;
                    break;
                }
            }
            if (ima == false)
            {
                MessageBox.Show("projekcija ne postoji!");
                return;
            }
            //ako postoji putanja i nije prazna
            if (File.Exists(putanjaKarta) && f.Length > 0)
            {
                //ovo nauci npmt

                //deserijalizacija karte
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaKarta);

                listaKarta = bf.Deserialize(fs) as List<Karta>;
                fs.Dispose();

                foreach (Karta krt in listaKarta)
                {

                    if (krt.id.ToString().Equals(idKarte.Text))
                    {
                        MessageBox.Show("Id vec postoji!");
                        return;
                    }
                }

                listaKarta.Add(new Karta(int.Parse(idKarte.Text), projekcija.film, projekcija.sala, int.Parse(sediste.Text), double.Parse(cena.Text)));

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaKarta);

                bfSer.Serialize(fsSer, listaKarta);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali kartu!");
            }
            else
            {
                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaKarta);

                listaKarta.Add(new Karta(int.Parse(idKarte.Text), projekcija.film, projekcija.sala, int.Parse(sediste.Text), double.Parse(cena.Text)));

                bfSer.Serialize(fsSer, listaKarta);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali kartu!");
            }
        }
    }
}
