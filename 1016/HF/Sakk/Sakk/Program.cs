using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakk
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabla t = new Tabla();
            t.Kiir();

            Console.ReadLine();

            Figura f = new Figura(Figura.SZINEK.fekete,2,3);
        }
    }
}
