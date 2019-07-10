using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamok2_35
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 35; i=i+2)
            {

                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("Bimbam");
                else if (i % 5 == 0) Console.WriteLine("Bam");
                else if (i % 3 == 0) Console.WriteLine("Bim");
                else Console.WriteLine(i+" ");

            }
        }
    }
}
