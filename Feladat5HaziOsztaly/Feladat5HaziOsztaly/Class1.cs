using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat5HaziOsztaly
{
    internal class Class1
    {
        string nev = "Cica";
        public string nev;
        public void beszel()
        {
            Console.WriteLine("Miau");
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
                _suly = Math.Abs(value);
            }
        }
    }
}
