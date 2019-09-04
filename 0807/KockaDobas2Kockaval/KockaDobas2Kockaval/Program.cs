using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaDobas2Kockaval
{
    class Program
    {
        static void Main(string[] args)
        {
            const int OLDALSZAMA = 7;
            int[][] dobasok = new int[OLDALSZAMA][];//6db sor, 0..6 ->1..6
            for (int i = 0; i < 7; i++){ dobasok[i] = new int[OLDALSZAMA]; }

            //fejlécek:
            for (int o = 1; o < OLDALSZAMA; o++)
            {
                dobasok[0][o] = o;
            }
            for (int s = 1; s < OLDALSZAMA; s++)
            {
                dobasok[s][0] = s;
            }

            int dobasokSzama = 3000;
            Random rnd = new Random();

            for (int i = 0; i < dobasokSzama; i++)
            {
                int dobas1 = rnd.Next(1, OLDALSZAMA);
                int dobas2 = rnd.Next(1, OLDALSZAMA);
                dobasok[dobas1][dobas2]++; 
            }

            Console.WriteLine($"{dobasokSzama} dobásból 2 kockával statisztika:");
            for (int i = 0; i < OLDALSZAMA; i++)
            {
                for (int j = 0; j < OLDALSZAMA; j++)
                {
                    Console.Write($"{dobasok[i][j],4} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
