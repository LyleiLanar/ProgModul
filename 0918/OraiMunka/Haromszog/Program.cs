using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Program
    {
        static void Main(string[] args)
        {
            Haromszog h = new Haromszog(-10,-10,-10);
            Haromszog eoh = new Haromszog();

            Console.WriteLine(h.ToString());
            Console.WriteLine(h.terulet());
        }
    }
}
