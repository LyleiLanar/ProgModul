using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumKeresés
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 2, c = 1;            
            Console.WriteLine((a>b && a>c) ? a : (b > c) ? b : c );
            Console.ReadLine();            
        }
    }
}
