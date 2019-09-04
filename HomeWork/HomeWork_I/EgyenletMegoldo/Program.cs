using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenletMegoldo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A program kiszámolja a*x+b=0 egyenlet eredményét tetszőleges valós számokra");

            Console.Write("Adja meg a-nak az értékét: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Adja meg b-nek az értékét: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //a*x+b=0 --> x = -(b/a)

            double x;

            if (a!=0)
            {
                x = -(b / a);
                Console.WriteLine($"Az egyenlet eredménye: {-(b / a):N4}");
            }
            else
            {
                Console.WriteLine("Nullával nem igazán lehet osztani... :(");
            }
        }
    }
}
