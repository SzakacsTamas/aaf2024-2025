using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viragagyasok
{
    internal class Adatok
    {
        public int kezd;
        public int veg;
        public string szin;

        public Adatok(string sor) 
        {
            string[] vag = sor.Split(" ");
            kezd = int.Parse(vag[0]);
        }
    }
}
