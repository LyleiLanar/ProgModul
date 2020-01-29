using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceCloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Pont p1 = new Pont(1,1);
            Pont p2 = p1;

            Console.WriteLine($"Módosítás előtt: p1{p1} p2:{p2}");
            p1.X = 0;

            Console.WriteLine($"Módosítás után: p1{p1} p2:{p2}");

            Console.WriteLine();


            PontCloneabe pc1 = new PontCloneabe(1, 1,"P");
            PontCloneabe pc2 = (PontCloneabe)pc1.Clone();

            Console.WriteLine($"Módosítás előtt: pc1: {pc1} pc2: {pc2}");
            pc1.X = 10;

            Console.WriteLine($"Módosítás után: pc1: {pc1} pc2: {pc2}");

            Console.ReadLine();

        }
    }
}
