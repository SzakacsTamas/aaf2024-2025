using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TancIskola;

namespace TancIskola
{

    internal class Program
    {
        static void Main(string[] args)
        {
            

            string[] olvas = File.ReadAllLines("tancrend.txt");
            List<adatok> tancok = new List<adatok>();

       

            for (int i = 0; i < olvas.Length; i+=3)

                {
                tancok.Add(new adatok(olvas[i], olvas[i + 1], olvas[i + 2]));



             

                }
            Console.WriteLine("2.Feladat");
            Console.WriteLine($"Az első tánc: { tancok.First().tanc}, az utolsó tánc: {tancok.Last().tanc}.");

            Console.WriteLine("3.Feladat");
            var sambaSzam = tancok.Where(sambaSzamai => sambaSzamai.tanc == "samba");
            Console.WriteLine("A szambát "+sambaSzam.Count()+" pár mutatta be.");

            Console.WriteLine("4.Feladat");
            var vilmaTancai = tancok.Where(vilma => vilma.lany == "Vilma").Select(tancos=>tancos.tanc).ToList(); 
            Console.WriteLine($"Vilma táncolt: {String.Join("-t, ", vilmaTancai)}-t");


            Console.WriteLine("5.Feladat");
            Console.WriteLine("Kérje be egy tánc nevét, hogy megtudjuk akkor épp kivel táncolt Vilma, ha táncolt: ");
            string tancKereses = Console.ReadLine();

         
            var keresesTanc = tancok.FirstOrDefault(kereses => kereses.tanc == tancKereses && kereses.lany == "Vilma"); 

            if (keresesTanc != null)
            {
         
                Console.WriteLine($"A {tancKereses} bemutatóján Vilma párja {keresesTanc.fiu} volt.");
            }
            else
            {
               
                Console.WriteLine($"Vilma nem táncolt {tancKereses}-t.");
            }


        }
    }
}
