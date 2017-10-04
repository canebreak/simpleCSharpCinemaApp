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
    public partial class OcenjivanjeProjekcije : Form
    {
        List<Projekcija> listaProjekcije;
        List<Film> listaOcena;
        Film film;
        bool ocenio;
        string putanjaOcena;
        string putanjaProjekcije;

        public OcenjivanjeProjekcije()
        {
            InitializeComponent();
            listaProjekcije = new List<Projekcija>();
            listaOcena = new List<Film>();
            putanjaOcena = "bazaocena.txt";
            putanjaProjekcije = "bazaprojekcije.txt";
            ocenio = false;
        }

        private void btnOceni_Click(object sender, EventArgs e)
        {
            if (ocenio == true)
            {
                MessageBox.Show("Vec ste dali ocenu!");
                return;
            }
            if (double.Parse(txtOcena.Text) > 5 || double.Parse(txtOcena.Text) < 1)
            {
                MessageBox.Show("Unesite ocenu od 1 do 5!");
                return;
            }
            if (txtOcena.Text.Trim().Length == 0)
            {
                MessageBox.Show("Popunite polje!");
                return;
            }
            else if (cbProjekcije.SelectedItem == null)
            {
                MessageBox.Show("Odaberite projekciju!");
                return;
            }

            FileInfo f = new FileInfo(putanjaOcena);

            //ako postoji putanja i nije prazna
            if (File.Exists(putanjaOcena) && f.Length > 0)
            {
                //deserijalizacija ocene
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaOcena);

                listaOcena = bf.Deserialize(fs) as List<Film>;
                fs.Dispose();
                //ako je onaj film u kombo boxu jednako onome u listiprojekcija onda se uzimaju atributi iz listeprojekcije i ubacuju u listuocena s tim sto se za ocenu stavlja onaj broj iz txtOcena
                foreach (Projekcija pro in listaProjekcije)
                {
                    if (pro.film.naziv.Equals(cbProjekcije.SelectedItem.ToString()))
                    {
                        //sada je film koji smo na pocetku gore napravili "Film film" ,film iz liste projekcija.ovo sam uradio da bi bilo lakse da se ubacuje u lisstu
                        film = pro.film;
                    }
                }
                //sada je ovde lakse da se ubacuje                                     //ocena iz txtOcena prebacena u double
                listaOcena.Add(new Film(film.id, film.naziv, film.zanr, film.opis, double.Parse(txtOcena.Text)));

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaOcena);

                bfSer.Serialize(fsSer, listaOcena);
                fsSer.Dispose();
                ocenio = true;
                MessageBox.Show("Uspesno ste ocenili film!");

            }
            else
            {//ovo je ako putanja ne postoji.onda samo serijalizuje,bez deserijalizacije.desirijalizuje se samo ako vec postoji fajl i napounjen je podacima da bi ce ti podaci sacuvali...
                foreach (Projekcija pro in listaProjekcije)
                {
                    if (pro.film.naziv.Equals(cbProjekcije.SelectedItem.ToString()))
                    {
                        film = pro.film;
                    }
                }

                listaOcena.Add(new Film(film.id, film.naziv, film.zanr, film.opis, double.Parse(txtOcena.Text)));

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaOcena);

                bfSer.Serialize(fsSer, listaOcena);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste ocenili film2!");
            }
        }

        private void OcenjivanjeProjekcije_Load(object sender, EventArgs e)
        {

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
    }
}
