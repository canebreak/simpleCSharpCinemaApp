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
    public partial class StatistikaSale : Form
    {
        List<Karta> listaKarata;
        List<ProdataKarta> listaProdataKarta;
        Karta karta;
        ProdataKarta prodataKarta;
        Sala sala;
        string putanjaKarata;
        string putanjaProdatihKarata;

        public StatistikaSale()
        {
            InitializeComponent();
            listaKarata = new List<Karta>();
            listaProdataKarta = new List<ProdataKarta>();
            putanjaKarata = "bazakarta.txt";
            putanjaProdatihKarata = "bazaprodatekarte.txt";
        }
      

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void StatistikaSale_Load(object sender, EventArgs e)
        {
            FileInfo p = new FileInfo(putanjaKarata);

            if (File.Exists(putanjaKarata) && p.Length > 0)
            {
                //deserijalizacija karata
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaKarata);

                listaKarata = bf.Deserialize(fs) as List<Karta>;
                fs.Dispose();

                foreach (Karta kar in listaKarata)
                {
                    cbProjekcije.Items.Add(kar.film.naziv);
                }

            }
            else
            {
                MessageBox.Show("Niste dodali kartu!");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo pk = new FileInfo(putanjaProdatihKarata);

            if (cbProjekcije.SelectedItem == null)
            {
                MessageBox.Show("Odaberite projekciju!");
                return;
            }

            if (File.Exists(putanjaProdatihKarata) && pk.Length > 0)
            {
                //deserijalizacija prodatih karata
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaProdatihKarata);

                listaProdataKarta = bf.Deserialize(fs) as List<ProdataKarta>;
                fs.Dispose();
            }
            else
            {
                MessageBox.Show("Karte nisu prodate!");
                return;
            }
            foreach (Karta kar in listaKarata)
            {
                if (kar.film.naziv.Equals(cbProjekcije.SelectedItem.ToString()))
                {
                    karta = kar;
                    sala = kar.sala;
                    break;
                }
            }
            //sabira broj prodatih karata
            double zbir = 0;


            foreach (ProdataKarta prod in listaProdataKarta)
            {
                if (prod.karta.film.naziv.Equals(karta.film.naziv))
                {
                    zbir += prod.brKarata;
                }
            }
            //prikazuje popunjenost sale u procentima
            double procenat = Math.Round((zbir / sala.brMesta) * 100, 1);
            Grafika gr = new Grafika(procenat);
            gr.Show();
        }
    }
}
