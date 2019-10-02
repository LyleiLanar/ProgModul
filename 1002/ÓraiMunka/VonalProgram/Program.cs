using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VonalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Vonal v1 = new Vonal();
            Console.WriteLine(v1.ToString());
            v1.rajzol();

            Vonal v2 = new Vonal(10);
            Console.WriteLine(v2.ToString());
            v2.rajzol();

            Vonal v3 = new Vonal(15,"Kacsa",Vonal.SZINEK.piros);
            Console.WriteLine(v3.ToString());
            v3.rajzol();

            Vonal rossz1 = new Vonal("Rossz",);


        }
    }
}
