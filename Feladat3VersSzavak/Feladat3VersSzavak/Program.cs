using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat3VersSzavak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dick=new Dictionary<string, int>();
            
            StreamReader szoveg = new StreamReader("szoveg.txt");

            while (!szoveg.EndOfStream) 
            {
                
                Console.WriteLine(szoveg.ReadLine());
            }

            szoveg.Close();
        }
        
    }
}
