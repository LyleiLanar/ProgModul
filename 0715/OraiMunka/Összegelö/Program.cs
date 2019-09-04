using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Összegelö
{
    class Program
    {
        static void Main(string[] args)
        {

            // megoldani az utolsó nulla esetét, mert azt még beveszi a kis buzi
            int szum = 0;
            int szam;
            int szamokSzama =0 ;
            bool nulla_e = false;

            do
            {
                Console.WriteLine("Adja meg egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());

                if (szam != 0)
                {
                    szum += szam;
                    szamokSzama++;
                }
                else
                {
                    nulla_e = true;                }                

            } while (!nulla_e);

            Console.WriteLine($"Az összeg: {szum}.");
            Console.WriteLine($"Az átlag: {(double)szum/szamokSzama}.");
        }
    }
}
