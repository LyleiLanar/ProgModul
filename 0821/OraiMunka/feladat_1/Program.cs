using System;

namespace feladat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = { -9, 14, -6, 21 };

            Random rnd = new Random();
            int[] szamok = new int[10];

            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(-20, 31);
                Console.Write($"{szamok[i]}, ");
            }
            Console.WriteLine();

            int szum = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                szum += szamok[i];

            }
            Console.WriteLine($"Szum: {szum}");
            Console.WriteLine($"Átlag: {(double)szum / szamok.Length}");

            int max_i = 0, min_i = 0;
            int max = szamok[max_i];
            int min = szamok[min_i];

            for (int i = 0; i < szamok.Length; i++)
            {
                if (max < szamok[i])
                {
                    max_i = i;
                    max = szamok[i];
                }

                if (min > szamok[i])
                {
                    min_i = i;
                    min = szamok[i];
                }
            }
            Console.WriteLine($"Min: [{min_i+1}]:{min}");
            Console.WriteLine($"Max: [{max_i+1}]:{max}");

            int it = 0;

            while (it < szamok.Length && (szamok[it] < 0 || szamok[it] % 2 != 0))
            {
                it++;
            }

            if (it < szamok.Length)
            {
                Console.WriteLine($"Első pozitív: [{it+1}]: {szamok[it]}");
            }

            it = 0;
            while (it < szamok.Length && szamok[it] > 0)
            {
                it++;
            }

            if (it == szamok.Length)
            {
                Console.WriteLine("Csak pozitív");
            }
            else
            {
                Console.WriteLine("NEM csak pozitív");
            }

            it = 0;
            int negativ_db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]<0)
                {
                    negativ_db++;
                }
            }
            Console.WriteLine($"Összesen {negativ_db} szám van.");

        }
    }
}
