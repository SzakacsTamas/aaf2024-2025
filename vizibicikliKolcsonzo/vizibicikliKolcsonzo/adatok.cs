using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vizibicikliKolcsonzo
{
    internal class adatok
    {
        public string nev;
        public string azonosito;
        public int elvitelOra;
        public int elvitelPerc;
        public int visszahozatalOra;
        public int visszahozatalPerc;

        public adatok(string nev, string azonosito, int elvitelOra, int elvitelPerc, int visszahozatalOra, int visszahozatalPerc)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.elvitelOra = elvitelOra;
            this.elvitelPerc = elvitelPerc;
            this.visszahozatalOra = visszahozatalOra;
            this.visszahozatalPerc = visszahozatalPerc;
        }
    }
}
