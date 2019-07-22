using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimSzam1
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 7;
            int oszto = 2;

            while (szam % oszto != 0 && oszto < szam / 2)
            {
                oszto++;
            }

            Console.WriteLine(szam / 2 == oszto ? "Primszam" : "Nem primszam");
            Console.ReadLine();
        }           
      
    }
}
