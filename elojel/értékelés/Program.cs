using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace értékelés
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjunk meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam < 0 || szam >100)
            {
                Console.WriteLine("Nem értékelhető");
            }
            else if (szam <= 40)
            {
                Console.WriteLine("1");
            }
            else if (szam <= 50)
            {
                Console.WriteLine("2");
            }
            else if (szam <= 60)
            {
                Console.WriteLine("3");
            }
            else if (szam <= 80)
            {
                Console.WriteLine("4");
            }
            else if (szam <= 100)
            {
                Console.WriteLine("5");
            }
            else
            {
                Console.WriteLine("Nem értékelhető");
            }            
        }
    }
}
