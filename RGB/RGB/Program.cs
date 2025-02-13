using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RGB;



namespace RGB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pixel> pixelek = new List<Pixel>();

            StreamReader olvas = new StreamReader("kep.txt");
            int x=1, y=1;
            while (!olvas.EndOfStream)
            {
                string line = olvas.ReadLine();
                string[] vag = line.Split(' ');
                x = 1;
                for (int i = 0; i < vag.Length; i+=3) 
                {
                    int r= int.Parse(vag[i]);
                    int g= int.Parse(vag[i+1]);
                    int b= int.Parse(vag[i+2]);
                    pixelek.Add(new Pixel(x,y,new Szin(r,g,b)));
                    x++;
                }
                y++;
            }
            olvas.Close();

            Console.WriteLine("2.feladat");
            Console.WriteLine("Kérem egy képpont adatait: ");
            Console.WriteLine("sor: ");
            int sor=int.Parse(Console.ReadLine());
            Console.WriteLine("oszlop: ");
            int oszlop = int.Parse(Console.ReadLine());

            var talalat=pixelek.Where(pont=>pont.x ==oszlop && pont.y == sor).ToArray()[0];

            Console.WriteLine("A képpont színe {0}",talalat.rgb);

            var vilagosok


        }
    }
}
