using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DobasStatisztika
{
    class Program
    {
        static void Main(string[] args)
        {
            const int OLDALSZAMA = 7;
            int[][] dobasok = new int[OLDALSZAMA][];//6db sor, 0..6 ->1..6
            for (int i = 0; i < 7; i++) { dobasok[i] = new int[OLDALSZAMA]; }

            int dobasokSzama = 30;
            Random rnd = new Random();

            for (int i = 0; i < dobasokSzama; i++)
            {
                int dobas1 = rnd.Next(1, OLDALSZAMA);
                int dobas2 = rnd.Next(1, OLDALSZAMA);
                dobasok[dobas1][dobas2]++;
            }

            /*teszteléshez eredeti kiírása*/
            //fejlécek:
            //for (int o = 1; o < OLDALSZAMA; o++)
            //{
            //    dobasok[0][o] = o;
            //}
            //for (int s = 1; s < OLDALSZAMA; s++)
            //{
            //    dobasok[s][0] = s;
            //}
            //Console.WriteLine($"{dobasokSzama} dobásból 2 kockával statisztika:");
            //for (int i = 0; i < OLDALSZAMA; i++)
            //{
            //    for (int j = 0; j < OLDALSZAMA; j++)
            //    {
            //        Console.Write($"{dobasok[i][j],4} ");
            //    }
            //    Console.WriteLine();
            //}
            /*tesztelés vége*/

            Console.WriteLine("eredmény");
            //eredmény tömb összeállítása
            int maxDobasInd = (OLDALSZAMA - 1) * 2 + 1;//2db 6 old. 12, index miatt 13
            int[] statisztika = new int[maxDobasInd];//0..12 -> 2..12
            for (int i = 1; i < OLDALSZAMA; i++)//i=1, mert 0. oldal nincs
            {
                for (int j = 1; j < OLDALSZAMA; j++)//j=1, mert 0. oldal nincs
                {
                    statisztika[i + j] += dobasok[i][j];
                }
            }

            //maximum kiv.:
            int maxInd = 2;//statisztika tömb első értékes indexe
            for (int i = 3; i < maxDobasInd; i++)
            {
                if (statisztika[i] > statisztika[maxInd])
                {
                    maxInd = i;
                }
            }
            //maximum kiv. vége

            //eredmény tömb kiírása
            for (int i = 2; i < maxDobasInd; i++)//2..12-ig
            {
                //értékek kiírása
                int ertek = statisztika[i];
                Console.Write($"{i,3} | {ertek,4} ");
                //csillagok kiírása
                double arany = (double)ertek / statisztika[maxInd];
                const int MAXCSILLAGDB = 40;
                for (int j = 0; j < arany * MAXCSILLAGDB; j++){ Console.Write("*"); }
                Console.WriteLine();
            }




            Console.ReadLine();
        }
    }
}
