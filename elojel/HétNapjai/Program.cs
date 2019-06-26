using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HétNapjai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjunk meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam >= 1 && szam <= 7)
            {
                if (szam <=5)
                {
                    Console.WriteLine("Hétköznap");
                }
                else
                {
                    Console.WriteLine("Hétvége");
                }
            }
            else
            {
                Console.WriteLine("Nincs ilyen nap");
            }

        }
    }
}
