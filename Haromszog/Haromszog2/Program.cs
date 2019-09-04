using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. befogó: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. befogó:  ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Átfogó ");
            int c = Convert.ToInt32(Console.ReadLine());

            //HF: próbáljuk megoldani csak ternálissal 

            if (a>c)
            {
                int csere = a;
                c = a;
                c = csere;
            }

            if (b > c)
            {
                int csere = b;
                c = b;
                c = csere;
            }

            Console.WriteLine("Az atfogó: {0}", c);

            int kerulet = a + b + c;
            double s = (double)kerulet / 2;
            double terület = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            string igaz = $"kerület={kerulet}, terület{terület}";
            string hamis = "nem szerkeszthető";
            bool feltétel = ((a + b > c) && (b + c > a) && (c + a > b));
            Console.WriteLine(feltétel ? igaz : hamis);

            

        }
    }
}
