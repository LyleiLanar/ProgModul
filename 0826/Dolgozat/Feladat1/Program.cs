using System;

namespace Feladat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Első feladat: ");
            double[] tomb = { 3, 7.74, -37.5, -4, 25, -7, 375.3, -17.4, 25, 19.2 };

            //átlag
            double szum = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                szum += tomb[i];
            }

            Console.WriteLine($"Átlag= {szum / tomb.Length}");

            //legnagyobb elem helye és legkisebb elem értéke
            double max_hely = 0;
            double max = double.MinValue;
            double min = double.MaxValue;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (max < tomb[i])
                {
                    max = tomb[i];
                    max_hely = i;
                }

                if (min > tomb[i])
                {
                    min = tomb[i];
                }
            }
            Console.WriteLine($"Legnagyobb elem sorszáma (ha 1-től indexelünk): {max_hely + 1}");
            Console.WriteLine($"Legkisebb elem: {min}");

            //negatív számok elemei
            int negativSzamok = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] < 0)
                {
                    Console.Write($"{tomb[i]} ");
                    negativSzamok++;
                }

            }
            Console.WriteLine();
            Console.WriteLine($"Összesen {negativSzamok} darab negatív szám van.");

            //tökéletes szám
            int it = 0;
            while (it < tomb.Length && szum == tomb[it])
            {
                szum = 0;
                for (int j = 1; j < tomb[it] / 2; j++)
                {
                    if (tomb[it] / j == 0)
                    {
                        szum += j;
                    }
                }
                it++;
            }

            if (it >= tomb.Length)
            {
                Console.WriteLine("Nincs tökéletes szám!");
            }
            else
            {
                Console.WriteLine($"Az első tökéletes szám: {tomb[it]}");
            }


            // ***** Második feladat (LKO) ******
            Console.WriteLine();

            Console.WriteLine("Második feladat: ");


            Console.Write("Adja meg m értékét: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg n értékét: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int r = m % n;

            while (r>0)
            {
                m = n;
                n = r;
                r = m % n;
            }

            Console.Write($"n értéke a ciklus végén: {n}\n");
            Console.WriteLine("Ez M és N legnagyobb közös osztója!");

            //***** Második feladat struktogram *****
            Console.WriteLine();
            Console.WriteLine("Második feladat struktogram: ");


            Console.Write("Adja meg A értékét: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adja meg B értékét: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int S = 1;

            while (B>0)
            {
                if (B%2!=0)
                {
                    S = S * A;
                    B--;
                }
                else
                {
                    A = A * A;
                    B = B / 2;
                }
            }

            Console.WriteLine($"Az algoritmus eredménye: {S}");

        }
    }
}

