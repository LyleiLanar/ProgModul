using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teglalap
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add meg a téglalap a oldalának hoszzát (mm): ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add meg a téglalap a oldalának hoszzát (mm): ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A téglalap kerülete: {0} mm.\nA területe pedig: {1} mm^2",(2*a)+(2*b),(a*+b));

        }
    }
}
