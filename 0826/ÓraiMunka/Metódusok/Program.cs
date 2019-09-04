using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metódusok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*egy szám dupláját kapjuk meg*/

            //eljárással
            Console.WriteLine(szamol("+", 4, 4)); 
        }

        private static double szamol(object muvelet, double szam1, double szam2)
        {
            switch (muvelet)
            {
                case "+":
                    return (szam1 + szam2);
                case "-":
                    return (szam1 - szam2);
                case "*":
                    return (szam1 * szam2);
                case "/":
                    return (szam1 / szam2);
                default:
                    throw new Exception("Bammeg");
            }
        }
    }
}
