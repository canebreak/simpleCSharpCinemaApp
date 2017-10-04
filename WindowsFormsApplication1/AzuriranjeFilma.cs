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
    public partial class AzuriranjeFilma : Form
    {
        List<Film> listaFilmova;
        string putanjaFilm;
        public AzuriranjeFilma()
        {
            InitializeComponent();
            listaFilmova = new List<Film>();
            putanjaFilm = "bazafilm.txt";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void addMovieButton_Click(object sender, EventArgs e)
        {
            FileInfo f = new FileInfo(putanjaFilm);
            int n;
            //ako su polja prazna;
            if (txtId.Text.Trim().Length == 0 || txtName.Text.Trim().Length == 0 || txtZanr.Text.Trim().Length == 0 || txtDesc.Text.Trim().Length == 0)
            {
                MessageBox.Show("popunite sva polja!");
            }
            if (int.TryParse(txtId.Text, out n) == false)
            {
                MessageBox.Show("Id filma mora biti broj");
            }
            if (File.Exists(putanjaFilm) && f.Length > 0)
            {
                //deserijalizacija
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.OpenRead(putanjaFilm);

                listaFilmova = bf.Deserialize(fs) as List<Film>;
                fs.Dispose();
                foreach (Film flm in listaFilmova)
                {
                    if (flm.id.Equals(int.Parse(txtId.Text)))
                    {
                        MessageBox.Show("ID vec postoji");
                        return;
                    }
                    if (flm.naziv.Equals(txtName.Text))
                    {
                        MessageBox.Show("Film vec postoji");
                        return;
                    }
                }
                listaFilmova.Add(new Film(int.Parse(txtId.Text), txtName.Text, txtZanr.Text, txtDesc.Text, 0));
                //serijalizaicija
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaFilm);

                bfSer.Serialize(fsSer, listaFilmova);
                fsSer.Dispose();

                MessageBox.Show("Film uspesno dodat");

            }
            else {
                BinaryFormatter bfSer = new BinaryFormatter();
                FileStream fsSer = File.OpenWrite(putanjaFilm);

                listaFilmova.Add(new Film(int.Parse(txtId.Text), txtName.Text, txtZanr.Text, txtDesc.Text, 0));

                bfSer.Serialize(fsSer, listaFilmova);
                fsSer.Dispose();

                MessageBox.Show("Film uspesno dodat");

            }
        }

        private void AzuriranjeFilma_Load(object sender, EventArgs e)
        {

        }
    }
}
