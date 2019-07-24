using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            string szum = "";
            string szoveg;

            for (int i = 0; i < n; i++)
            {
                szoveg = Console.ReadLine();
                szum += szoveg;
            }

            Console.WriteLine(szum);
            Console.ReadLine();
        }
    }
}
