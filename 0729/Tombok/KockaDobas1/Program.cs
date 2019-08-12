using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaDobas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int dobasokSzama;
            char ujra = 'i';
            do
            {
                do
                {
                    Console.Write("hányszor dobjak: ");
                    int.TryParse(Console.ReadLine(), out dobasokSzama);

                } while (dobasokSzama < 1);

                const int OLDAL = 6;
                int[] dobasokTomb = new int[OLDAL + 1];//0..OLDAL
                Random rnd = new Random();
                for (int i = 0; i < dobasokSzama; i++)
                {
                    int dobas = rnd.Next(1, OLDAL + 1);//1..OLDAL
                    dobasokTomb[dobas]++;
                }

                Console.WriteLine("Dobások statisztika:");
                for (int i = 1; i < OLDAL + 1; i++)
                {
                    Console.WriteLine($"{i} volt {dobasokTomb[i]}");
                }
                Console.Write("újra? (i/n): ");
                ujra = Console.ReadLine()[0];
            } while (ujra == 'i');

        }
    }
}
