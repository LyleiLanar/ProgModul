using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltalanosHaromszog
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszog h = new Haromszog(4,5,6);
            Console.WriteLine(h.ToString());

            EgyenloSzaruHaromszog eszh = new EgyenloSzaruHaromszog(2, 3);
            Console.WriteLine(eszh.ToString());

            EgyenloOldaluHaromszog eoh = new EgyenloOldaluHaromszog(1);
            Console.WriteLine(eoh.ToString());


        }
    }
}
