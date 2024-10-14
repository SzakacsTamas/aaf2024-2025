using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat9LezerLoveszet
{
    
    internal class JatekosLovese
    {
        
        public JatekosLovese()
        {
            StreamReader olvas = new StreamReader("lovesek.txt");
            string celTabla=olvas.ReadLine();
            celTabla.Split(";");
            double celTablaX = Convert.ToDouble(celTabla.Split(";")[0]);
            double celTablaY = Convert.ToDouble(celTabla.Split(";")[1]);
            List<string> nev = new List<string>();
            List<double> xKordinata = new List<double>();
            List<double> yKordinata = new List<double>();

            while (!olvas.EndOfStream)
            {
                string line=olvas.ReadLine();
                nev.Add(line.Split(";")[0]);
                xKordinata.Add(Convert.ToDouble(line.Split(";")[1]));
                yKordinata.Add(Convert.ToDouble(line.Split(";")[2]));
        
            }
        }
    }
}
