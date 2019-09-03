using System;
using System.Diagnostics;

namespace BeadandoKodok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A VERZIÓ */
            Stopwatch stopper = new Stopwatch();
            Random rnd = new Random();

            stopper.Start();


            int[] joSzamok = new int[5];

            int joSzamokDb = 0;
            do
            {
                int szam = rnd.Next(1, 91);

                //eldöntés
                int i = 0;
                while (i < joSzamokDb && !(joSzamok[i] == szam))
                {
                    i++;
                }

                if (i >= joSzamokDb)
                {
                    joSzamok[joSzamokDb] = szam;
                    joSzamokDb++;
                }

            } while (joSzamokDb < 5);

            //foreach (var item in joSzamok)
            //{
            //    Console.Write(item + " ");
            //}


            stopper.Stop();
            //Console.WriteLine();
            Console.WriteLine(stopper.ElapsedTicks);


            /* B VERZIÓ */
            stopper.Reset();
            stopper.Start();

            int[] lottóTömb = new int[5];
            int tipp, j;
            for (int jóSzámDb = 1; jóSzámDb <= 5; jóSzámDb++)
            {
                do
                {
                    tipp = rnd.Next(90) + 1;
                    j = 0;

                    while (j < jóSzámDb && !(lottóTömb[j] == tipp))
                        j++;

                } while (j < jóSzámDb);
                lottóTömb[jóSzámDb - 1] = tipp;
            }
            //foreach (var item in lottóTömb)
            //{
            //    Console.Write(item + " ");
            //}
            stopper.Stop();
            //Console.WriteLine();
            Console.WriteLine(stopper.ElapsedTicks);



            Console.ReadLine();

        }
    }
}
