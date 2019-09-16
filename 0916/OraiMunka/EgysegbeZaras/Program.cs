using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgysegbeZaras
{
    class Program
    {
        int szamlalo;
        int nevezo;

        static void Main(string[] args)
        {

            Program p = new Program();

            p.nevezo = 3;
            p.szamlalo = 1;

            Console.WriteLine($"A tört értéke {p.szamlalo}/{p.nevezo}.");

            Console.ReadLine();
        }
    }
}
