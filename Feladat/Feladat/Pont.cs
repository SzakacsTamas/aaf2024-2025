using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace definialosCucc
{
    internal class Pont
    {
        public int x;
        public int y;
        public Pont(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Pont(int x)
        {
            this.x = x;
            y = 0;
        }
        public Pont()
        {
            y = 0;
            x = 0;
        }
        public static Pont operator +(Pont a, Pont b)
        {
            return new Pont(a.x + b.x, a.y + b.y);
        }
        public override string ToString()
        {
            return "x: " + x + ", y: " + y;
        }
    }
}