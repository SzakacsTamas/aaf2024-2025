using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat5ObjektumOrientalt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            kutya k =new kutya();
            k.ugat();
            k.suly = 12;
            Console.WriteLine(k.suly);
            Console.WriteLine();
        }
    }
}
