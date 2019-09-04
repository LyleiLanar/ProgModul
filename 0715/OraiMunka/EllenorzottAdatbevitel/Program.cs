using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllenorzottAdatbevitel
{
    class Program
    {
        static void Main(string[] args)
        {

            int szam;

            bool jo = false;
            do
            {
                Console.Write("Adj meg egy pozitív ketejegyű négyzetszámot: ");
                szam = Convert.ToInt32(Console.ReadLine());

                bool ketjegyu = (szam > 9 && szam < 100);
                bool paros = szam % 2 == 0;

                int gyok = (int)Math.Sqrt(szam);
                bool negyzetszam = gyok * gyok == szam;

                jo = (ketjegyu && paros && negyzetszam);

                if (!jo) Console.WriteLine("Nem jó!");

            } while (!jo);

            Console.WriteLine("Király, végre egy pozitív háromjegyű páros szám!!!");

        }
    }
}
