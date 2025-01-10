using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatokFeladat
{
    internal class Csorda
    {
        List<Allat> tagok=new List<Allat>();

        public Csorda() { }
        public Csorda(Allat allat)
        {  tagok.Add(allat); }
        public Csorda(Csorda csorda)
        {
            this.tagok.Addrange(csorda.tagok);
        }
        public static Csorda operator +(Csorda cs1, Allat a1)
        {
            cs1.tagok
        }
    }
}
