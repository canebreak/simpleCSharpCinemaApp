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
    public partial class AzuriranjeProjekcije : Form
    {
        List<Projekcija> listaProjekcije;
        List<Film> listaFilm;
        List<Sala> listaSala;
        Sala sala;
        Film film;
        string putanjaProjekcije;
        string putanjaFilm;
        string putanjaSala;

        public AzuriranjeProjekcije()
        {
            InitializeComponent();
            listaProjekcije = new List<Projekcija>();
            listaFilm = new List<Film>();
            listaSala = new List<Sala>();
            putanjaProjekcije = "bazaprojekcije.txt";
            putanjaFilm = "bazafilm.txt";
            putanjaSala = "bazasala.txt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo p = new FileInfo(putanjaProjekcije);
            FileInfo f = new FileInfo(putanjaFilm);
            FileInfo s = new FileInfo(putanjaSala);

            int n;
            bool ima = false;

            if (idProjekcije.Text.Trim().Length == 0 || nazivFilma.Text.Trim().Length == 0 || nazivSale.Text.Trim().Length == 0 || vreme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Morate popuniti sva polja");
                return;
            }
            if (int.TryParse(idProjekcije.Text, out n) == false)
            {
                MessageBox.Show("ID mora biti broj");
                return;
            }
            if (File.Exists(putanjaFilm) && f.Length > 0 && File.Exists(putanjaSala) && s.Length > 0)
            {
                //deserijalizacija sale
                BinaryFormatter bfSala = new BinaryFormatter();
                FileStream fsSala = File.OpenRead(putanjaSala);

                listaSala = bfSala.Deserialize(fsSala) as List<Sala>;
                fsSala.Dispose();

                //deserijalizacija filma
                BinaryFormatter bfFilm = new BinaryFormatter();
                FileStream fsFilm = File.OpenRead(putanjaFilm);

                listaFilm = bfFilm.Deserialize(fsFilm) as List<Film>;
                fsFilm.Dispose();

                foreach (Film flm in listaFilm)
                {
                    //ako je film iz text fajla razlicit od onog u txtBoxu onda znaci da film ne postoji i ne moze da se doda projekcija,a ako postoji film = flm i dodajeu listu..
                    if (flm.naziv.Equals(nazivFilma.Text))
                    {
                        film = flm;
                        ima = true;
                        break;
                    }
                }
                if (ima == false)
                {
                    MessageBox.Show("film ne postoji!");
                    return;
                }

                foreach (Sala sla in listaSala)
                {
                    //isto kao gore,ali za sale
                    if (sla.naziv.Equals(nazivSale.Text))
                    {
                        sala = sla;
                        ima = true;
                        break;
                    }
                }
                if (ima == false)
                {
                    MessageBox.Show("Sala ne postoji!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Niste dodali film ili salu!");
                return;
            }
            //ako postoji putanja i nije prazna
            if (File.Exists(putanjaProjekcije) && p.Length > 0)
            {
                //ovo nauci npmt

                //deserijalizacija
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaProjekcije);

                listaProjekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Dispose();

                foreach (Projekcija pro in listaProjekcije)
                {

                    if (pro.id.ToString().Equals(idProjekcije.Text))
                    {
                        MessageBox.Show("Id vec postoji!");
                        return;
                    }
                    else if (pro.film.naziv.Equals(nazivFilma.Text))
                    {
                        MessageBox.Show("Projekcija vec postoji!");
                        return;
                    }
                }

                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaProjekcije);

                listaProjekcije.Add(new Projekcija(int.Parse(idProjekcije.Text), film, sala, vreme.Text));

                bfSer.Serialize(fsSer, listaProjekcije);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali projekciju!");
            }
            else
            {
                //serijalizacija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaProjekcije);

                listaProjekcije.Add(new Projekcija(int.Parse(idProjekcije.Text), film, sala, vreme.Text));

                bfSer.Serialize(fsSer, listaProjekcije);
                fsSer.Dispose();

                MessageBox.Show("Uspesno ste dodali projekciju!");
            }
        }

    }
}
