using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Program
    {
        static void Main(string[] args)
        {
            Etterem bufe = new Etterem();

            bufe.Kiir();
            bufe.EtelRendeles("Kék","Gyümölcsleves");
            bufe.EtelRendeles("Kék", "Gyümölcsleves");
            bufe.EtelRendeles("Kék", "Gyümölcsleves");
            Console.ReadLine();

        }
    }
}
