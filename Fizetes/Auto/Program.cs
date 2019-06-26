using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            bool benzin = true;
            bool diesel = false;

            if (benzin ^ diesel) //kizáró vagy operátor ez a szar
            {
                Console.WriteLine("van ilyen autó!");
            }
            else
            {
                Console.WriteLine("Hibrid vagy nincs ilyen aztü");
            }

            Console.ReadLine();
        }
    }
}
