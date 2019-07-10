using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbraFeladat
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adja be az egyik értéket: ");
            int aO = Convert.ToInt32(Console.ReadLine());
            int a = aO;
            Console.Write("Adja be a másik értéket: ");
            int bO = Convert.ToInt32(Console.ReadLine());
            int b = bO;
            int s, m, lnko, lkkt;

            if (a > b && b > 0)
            {
                s = a * b;
                m = a % b;                
                
                for (int i = 0; i != m;)
                {
                    a = b;
                    b = m;
                    m = a % b;                   
                }

                lnko = b;
                lkkt = s / lnko;

                Console.WriteLine($"LNKO ({aO},{bO}): {lnko}");
                Console.WriteLine($"LKKT [{aO},{bO}]: {lkkt}");
            }
            else
            {
                Console.WriteLine("Mind a két szám legyen pozitív!!!");
            }

            

        }
    }
}
