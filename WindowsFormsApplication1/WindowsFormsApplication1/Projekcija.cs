using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class Projekcija
    {
        public int id;
        public string vreme;
        public Film film;
        public Sala sala;

        public Projekcija(int id, Film film, Sala sala, string vreme)
        {
            this.id = id;
            this.film = film;
            this.sala = sala;
            this.vreme = vreme;
        }
        public override string ToString()
        {
            return id + " " + film + " " + sala + " " + vreme;
        }
    }

}
