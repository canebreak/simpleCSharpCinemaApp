using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

    [Serializable]
    class Sala
    {
        public int id;
        public int brMesta;
        public string naziv;

        public Sala(int id, string naziv, int brMesta)
        {
            this.id = id;
            this.naziv = naziv;
            this.brMesta = brMesta;
        }
        public override string ToString()
        {
            return id + " " + naziv + " | " + brMesta;
        }
    }
}
