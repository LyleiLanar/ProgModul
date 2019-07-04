using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikorVanHusvet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adjuk meg az évet: ");
            int evszam = Convert.ToInt32(Console.ReadLine());

            int a = evszam % 19;
            int b = evszam % 4;
            int c = evszam % 7;

            int d = (19 * a + 24) % 30;
            int e = (2 * b + 4 * c + 6 * d + 5) % 7;

            if (evszam<2100 && evszam>1900)
            {
                if ((d + e) < 10)
                {
                    Console.WriteLine($"Ebben az évben a húsvét március {d + e + 22}. napjára esik");
                }
                else if ((d + e - 9) == 26)
                {
                    Console.WriteLine($"Ebben az évben a húsvét április 19. napjára esik");
                }
                else if ((d + e - 9) == 25 && d == 28 && e == 6 && a > 10)
                {
                    Console.WriteLine($"Ebben az évben a húsvét április 18. napjára esik");
                }
                else
                {
                    Console.WriteLine($"Ebben az évben a húsvét április {d + e - 9}. napjára esik");
                }
            }
            else
            {
                Console.WriteLine("Nem megfelelő évszám lett megadva!");
            }


        }
    }
}
