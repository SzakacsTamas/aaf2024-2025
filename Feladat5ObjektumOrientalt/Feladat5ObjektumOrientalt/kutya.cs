using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Feladat5ObjektumOrientalt
{
    internal class kutya
    {
        public string nev;
        public void ugat()
        {
            Console.WriteLine("Vauuu");
        }
        private float _suly;

        public float suly
        {
            get
            {
                return _suly;
            }
            set
            {
                _suly= Math.Abs(value);
            }
        }
        public kutya(string nev)
        {
            this.nev = nev;
            Console.WriteLine("Kutya létrejött");
        }
        public override string ToString() {

        }
    }
}
