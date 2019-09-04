using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszegzes_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            double szum = 1.0; 
            
            for (int i = 1; i <= n; i++)
            {                                              
                szum *= i;
            }

            Console.WriteLine($"elso {n} szam szorzata: {szum}");
            Console.ReadLine();
        }
    }
}
