using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikusKotes
{
    class Program
    {
        static void Main(string[] args)
        {
            C1 obj1 = new C1();
            C2 obj2 = new C2();

            obj1.M2();
            obj2.M2();
            obj1.M1();
            obj2.M1();

            Console.ReadLine();
        }
    }
}
