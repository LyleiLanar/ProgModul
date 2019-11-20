using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            Garazs g = new Garazs();

           
            Auto a = new Auto("Peti");
            g.addAuto(a);
            Console.WriteLine(g);

            Console.ReadLine();

        }
    }
}
