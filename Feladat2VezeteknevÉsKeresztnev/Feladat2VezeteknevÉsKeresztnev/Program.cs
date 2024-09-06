using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2VezeteknevÉsKeresztnev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader kNev = new StreamReader("keresztnev.txt");
            StreamReader vNev = new StreamReader("vezeteknev.txt");

            List<string> kNevLista = new List<string>();
            List<string> vNevLista = new List<string>();
            List<string> nevek = new List<string>();


            while (!kNev.EndOfStream)
            {
                string kereszt = kNev.ReadLine();
                string vezet=vNev.ReadLine();

                kNevLista.Add(kereszt);
                vNevLista.Add(vezet);
                nevek.Add(kereszt);
                nevek.Add(vezet);

            }

            for (int i = 0; i < nevek.Count; i++) {
                Console.WriteLine(nevek[i]);
            }
            StreamWriter nevsek = new StreamWriter("TeljesNevek.txt");
            for (int i = 0; i < 100; i++) {

                nevsek.WriteLine(vNevLista[i] + " " + kNevLista[i]);

            
            }
            nevsek.Close();
        }
    }
}
