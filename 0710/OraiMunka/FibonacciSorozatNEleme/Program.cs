using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSorozatNEleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg, hogy hanyadik értéket szeretnéd megkapni a Fibonacci-sorozatból: ");
            int n = Convert.ToInt32(Console.ReadLine());
            long a = 1;
            long b = 1;
            long c = 0;

            Console.Write(a + " ");
            Console.Write(b + " ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.Write(c + " ");
            }

            Console.ReadLine();
        }
    }
}
