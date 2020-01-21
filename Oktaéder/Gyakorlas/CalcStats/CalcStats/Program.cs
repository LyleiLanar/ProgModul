using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcStats
{
    class Program
    {
        static void Main(string[] args)
        {             
            CalcStat cs = new CalcStat(SorozatGenerator.UjSorozat(10, 10, 30)) ;
            cs.Kiertekeles();

            Console.ReadLine();
        }
    }
}
