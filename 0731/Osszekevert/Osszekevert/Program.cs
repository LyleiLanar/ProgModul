using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszekevert
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DB = 9;
            //char[] betuk = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i' };
            char[] betuk = new char[DB];
            for (int i = 0; i < DB; i++){ betuk[i] = (char)(i + 97); }

            int[] sorrend = { 7, 8, 3, 2, 4, 6, 5, 0, 1 };

            for (int i = 0; i < DB; i++)
            {
                if (i % 3 == 0) { Console.WriteLine(); }
                Console.Write(betuk[i]);
            }
            Console.WriteLine();

            int sor, oszlop;
            Console.Write("sor: ");
            int.TryParse(Console.ReadLine(), out sor);
            Console.Write("oszlop: ");
            int.TryParse(Console.ReadLine(), out oszlop);

            //int index = sor * 3 + oszlop;
            int index = (sor-1) * 3 + (oszlop-1);
            Console.WriteLine(betuk[index]);

            for (int i = 0; i < DB; i++)
            {
                if (i % 3 == 0) { Console.WriteLine(); }
                Console.Write(betuk[sorrend[i]]);
            }
            Console.WriteLine();

            Console.Write("sor: ");
            int.TryParse(Console.ReadLine(), out sor);
            Console.Write("oszlop: ");
            int.TryParse(Console.ReadLine(), out oszlop);
            index = sor - 1 * 3 + oszlop - 1;
            Console.WriteLine(betuk[index]);


            Console.ReadLine();
        }
    }
}
