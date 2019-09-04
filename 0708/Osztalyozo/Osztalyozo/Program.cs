using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg a oszályzatot: ");
            int osztalyzat = Convert.ToInt32(Console.ReadLine());
            string eretekeles = "hibas";

            switch (osztalyzat)
            {
                case 1:
                    eretekeles = "egyes"; break;

                case 2:
                    eretekeles = "kettes"; break;

                case 3:
                    eretekeles = "harmas"; break;

                case 4:
                    eretekeles = "negyes"; ; break;

                case 5:
                    eretekeles = "otos"; ; break;

                default:
                    break;
            }
            Console.WriteLine(eretekeles);
        }
    }
}
