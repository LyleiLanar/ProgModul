using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingBevezeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"min(4, 5): {min(4, 5)}");
            Console.WriteLine($"min(4, 5, 2): {min(4, 5, 2)}");
            Console.WriteLine($"min(3.14, 1.5): {min(3.14, 1.5)}");
            Console.WriteLine($"min('a','B'): {min('a','B')}");            
        }

        private static char min(char a, char b)
        {
            return a < b ? a : b;
        }
        private static double min(double a, double b)
        {
            return a < b ? a : b;
        }

        private static int min(int a, int b, int c)
        {
           return min(a, min(b, c));
        }

        private static int min(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}
