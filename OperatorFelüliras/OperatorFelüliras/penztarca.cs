using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorFelüliras
{
    internal class penztarca
    {
        public int penz;
        public int hitel;
       
        internal penztarca(int penz)
        {
            this.penz = penz;
     
        }

    public static penztarca operator -(penztarca tarca,penztarca penzElvesz)
        {
            return new penztarca(tarca.penz - penzElvesz.penz);
        }

        public static penztarca operator +(penztarca tarca, penztarca penzAd)
        {
            return new penztarca(tarca.penz + penzAd.penz);
        }
        public override string ToString() 
        {
            return "Összeg: " + penz;
        }
    }
}
