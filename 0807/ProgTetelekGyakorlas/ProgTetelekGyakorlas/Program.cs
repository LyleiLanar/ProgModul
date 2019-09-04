using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgTetelekGyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //létrehozás
            int[] tomb = new int[10];
            //feltöltés
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                tomb[i] = rnd.Next(10, 100);
            }
            tomb[rnd.Next(10)] = rnd.Next(45) * 2 + 11;
            //kiiírás
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();

            /* prog tételek */
            //összegzés

            //szélsőértékek

            //van e benne 50-nél nagyobb?

            //mind páratlan e?

            //adjuk meg az első prímet, ha van

            //extra: a sorozat (monoton) növekvő e?

            Console.ReadLine();
        }
    }
}
