using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizetes
{
    class Program
    {
        static void Main(string[] args)
        {

            bool bankkartya = true;
            bool keszpenz = true;

            if (bankkartya || keszpenz)
            {
                Console.WriteLine("A termék kifizetve!");
            }
            else
            {
                Console.WriteLine("Nincs fedezet!");
            }

            Console.ReadLine();
        }
    }
}
