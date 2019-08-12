using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoKodok
{
    class Program
    {
        static void Main(string[] args)
        {
            /* A VERZIÓ */
			int[] joSzamok = new int[5];
 
            Random rnd = new Random();
 
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

            
            /* B VERZIÓ */
            int[] lottóTömb = new int[5];
            int tipp, j;
            for (int jóSzámDb = 1; jóSzámDb <= 5; jóSzámDb++)
            {
                do
                {
                    tipp = (int)(new Random().Next(90) + 1);
                    j = 0;
                    while (j < jóSzámDb && !(lottóTömb[j] == tipp))
                        j++;
                } while (j < jóSzámDb);
                lottóTömb[jóSzámDb - 1] = tipp;
            }
            foreach (var item in lottóTömb)
            {
                Console.Write(item + " ");
            }
            Console.ReadLine();
        }
    }
}
