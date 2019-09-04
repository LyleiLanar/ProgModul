using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(1,100);
            Console.Write("Adj be egy értéket: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCsere előtt:");
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("\nCsere után:");
            Console.WriteLine($"a:{a}");
            Console.WriteLine($"b:{b}");


        }
    }
}
