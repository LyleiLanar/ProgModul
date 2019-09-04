using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a oldal (mm): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b oldal (mm): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c oldal(mm): ");
            int c = Convert.ToInt32(Console.ReadLine());            

            int kerulet = a + b + c;                
            double s = (double) kerulet / 2;
            double terület = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            string igaz = $"kerület={kerulet}, terület{terület}";
            string hamis = "nem szerkeszthető";
            bool feltétel = ((a + b > c) && (b + c > a) && (c + a > b));

            Console.WriteLine(feltétel ? igaz : hamis);



        }
    }
}
