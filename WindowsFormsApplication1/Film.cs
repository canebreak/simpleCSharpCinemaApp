using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Film
    {
        public int id;
        public string naziv, zanr, opis;
        public double ocena;


        public Film(int id, string naziv, string zanr, string opis, double ocena)
        {
            this.id = id;
            this.naziv = naziv;
            this.zanr = zanr;
            this.opis = opis;
            this.ocena = ocena;
        }

        public override string ToString()
        {
            return this.id + " " + this.naziv + " " + this.zanr + " " + this.opis + " " + this.ocena;
        }
    }

}
