using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absolutertek
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Adjuk meg a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            int szamAbs = szam;

            if (szam < 0)
            {
                szamAbs = -szam;                
            }

            Console.WriteLine("Szám abszolútértéke: {0}", szamAbs);
        }
    }
}
