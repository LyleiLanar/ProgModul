using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdottSzamOsszesOsztoja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek add meg azt a számot, aminek szeretnénk megismerni az összes osztóját: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"{szam} összes osztója: ");
            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.Write($"{szam}.");
            Console.ReadLine();
        }
    }
}
