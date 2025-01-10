using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beleptetoADat
{
    internal class Adatok
    {
        public string kod;
        public string ido;
        public int esemeny;

        public Adatok (string sor)
        {
            string[] vag= sor.Split (' ');
            kod= vag[0];
            ido= vag[1];
            esemeny=Convert.ToInt32(vag[2]);
        }
    }
}
