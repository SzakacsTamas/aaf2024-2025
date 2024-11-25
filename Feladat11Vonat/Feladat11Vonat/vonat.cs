using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat11Vonat
{
    internal class vonat
    {
        public int kocsi;

        public vonat (int kocsi)
        {
            this.kocsi = kocsi;
        }
        public static vonat operator +(vonat v1,vonat v2)
        {
            return new vonat(v1.kocsi + v2.kocsi);
        }
        public static vonat operator -(vonat v1, vonat v2)
        {
            return new vonat(v2.kocsi - v1.kocsi);
        }
        public override string ToString()
        {
            return kocsi+" darab";
        }
    }
}
