using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyozóIfekkel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a oszályzatot: ");
            int osztalyzat = Convert.ToInt32(Console.ReadLine());

            if (osztalyzat >= 1 && osztalyzat <= 5)
            {
                if (osztalyzat == 1)
                {
                    Console.WriteLine("Büdös karó!");
                }

                if (osztalyzat == 2)
                {
                    Console.WriteLine("Büdös kettes!");
                }

                if (osztalyzat == 3)
                {
                    Console.WriteLine("Majdnem jó, ez egy hármas!");
                }

                if (osztalyzat == 4)
                {
                    Console.WriteLine("Nah, ez egy négyes!");
                }

                if (osztalyzat == 5)
                {
                    Console.WriteLine("Egész jó, de lehetne egy kicsit jobb. ÖTÖS!!!");
                }
            }
            else
            {
                Console.WriteLine("Na húzz a picsába!!!");
            }
        }
    }
}
