using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Karta
    {
        public int id;
        public int sediste;
        public Film film;
        public Sala sala;
        public double cena;

        public Karta(int id, Film film, Sala sala, int sediste, double cena)
        {
            this.id = id;
            this.film = film;
            this.sala = sala;
            this.sediste = sediste;
            this.cena = cena;
        }
        public override string ToString()
        {
            return id + " " + film + " | " + sala + " | " + sediste;
        }
    }
}
