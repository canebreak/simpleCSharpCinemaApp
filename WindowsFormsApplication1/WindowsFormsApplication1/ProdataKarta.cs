using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    [Serializable]
    class ProdataKarta
    {
        public int brKarata;
        public Karta karta;

        public ProdataKarta(int brKarata, Karta karta)
        {
            this.brKarata = brKarata;
            this.karta = karta;
        }
    }
}
