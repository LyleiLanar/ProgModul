using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileCiklus
{
    class Program
    {
        static void Main(string[] args)
        {

            int szam;

            do
            {
                Console.Write("Adj egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());

            } while (szam != 0);

            Console.WriteLine("0-ra kiléptem!!!");

            Console.ReadLine();           
        }
    }
}
