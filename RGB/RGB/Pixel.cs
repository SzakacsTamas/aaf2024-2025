using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGB
{
    internal class Pixel
    {
        public int x;
        public int y;
        public Szin rgb;

        public Pixel(int x, int y, Szin rgb)
        {
            this.x = x;
            this.y = y;
            this.rgb = rgb;
        }

    }
}
