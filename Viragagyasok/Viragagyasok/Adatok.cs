using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viragAgyas
{
    internal class adatok
    {
        public int kezd;
        public int veg;
        public string szin;
        public int sorSzam;

        public adatok(string sor)
        {
            string[] adatok = sor.Split(' ');
            this.kezd = int.Parse(adatok[0]);
            this.veg = int.Parse(adatok[1]);
            this.szin = adatok[2];
        }

        public bool kapuBentVan
        {
            get { return kezd > veg; }

        }

        public bool benneVanEz(int sorSzam)
        {

            return (kezd <= sorSzam && sorSzam <= veg) || (kapuBentVan && (kezd <= sorSzam || sorSzam <= veg));
        }
    }
}