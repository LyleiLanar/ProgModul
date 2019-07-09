using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejVagyIras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hányszor dobjunk fel egy érmét: ");
            int feldobasokSzama = Convert.ToInt32(Console.ReadLine());
            int fejekSzama = 0;

            Random rnd = new Random();

            for (int i = 0; i < feldobasokSzama; i++)
            {
                //  nulla a fej, egy az írás
                if (rnd.Next(0, 2) == 0)
                {
                    fejekSzama++;
                }
            }

            Console.WriteLine($"Összesen {fejekSzama} FEJ!");
            Console.WriteLine($"Összesen {feldobasokSzama - fejekSzama} ÍRÁS!");

        }
    }
}
