using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloPéldák
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 7;
            bool paros = szam % 2 == 0;

            Console.WriteLine(paros ? "páros" : "páratlan"); // feltétel ? igaz : hamis

            string eredmeny = paros ? "páros" : "páratlan"; // ez egy ilyen ternális (ternary) operátor, mert ez egy három operandusú operátor
            Console.WriteLine("A szám {0}.",eredmeny);            
        }
    }
}
