using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzoBeadando
{
    internal class adatok
    {
        public string nev;
        public string azonosito;
        public int elvitelOra;
        public int elvitelPerc;
        public int visszahozasOra;
        public int visszahozasPerc;

        public adatok(string nev, string azonosito, int elvitelOra, int elvitelPerc, int visszahozasOra, int visszahozasPerc)
        {
            this.nev = nev;
            this.azonosito = azonosito;
            this.elvitelOra = elvitelOra;
            this.elvitelPerc = elvitelPerc;
            this.visszahozasOra = visszahozasOra;
            this.visszahozasPerc = visszahozasPerc;
        }
    }
}
