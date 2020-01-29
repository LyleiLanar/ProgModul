using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            HengerTarolo ht = new HengerTarolo();

            ht.AddNewHenger(new UregesHenger(1, 1, 0.5));
            ht.AddNewHenger(new TomorHenger(1, 1));
            ht.AddNewHenger(new TomorHenger(1, 2));


            foreach (var item in ht)
            {                
                Console.WriteLine(item);
            }

            Console.WriteLine(ht.MinV());

            Console.ReadLine();

        }
    }
}
