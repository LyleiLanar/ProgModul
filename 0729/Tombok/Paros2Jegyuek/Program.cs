using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paros2Jegyuek
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DB = 3;
            Console.WriteLine($"eltárol és kiír {DB}db páros 2jegyű számot");
            int[] adatok = new int[DB];
            bool jo;
            int joDb = 0;
            do
            {
                Console.Write($"{joDb+1}. páros 2jegyű: ");
                int.TryParse(Console.ReadLine(), out int szam);
                bool paros = szam % 2 == 0;
                bool jegy2 = szam >= 10 && szam <= 99;
                jo = paros && jegy2;
                if (jo)
                {
                    adatok[joDb++] = szam;
                    //++joDb;
                }
            } while (!(joDb >= DB));
            Console.WriteLine($"megvan a 3 db szám");

            Console.ReadLine();
        }
    }
}
