using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diversion
{
    class Program
    {       

        static void Main(string[] args)
        {
            int maxdigit = 3;

            List<BinaryCombination> myBinaryCombinations = new List<BinaryCombination>();

            for (int i = 1; i <= maxdigit; i++)
            {
                myBinaryCombinations.Add(new BinaryCombination(i));
            }

            for (int i = 0; i < myBinaryCombinations.Count; i++)
            {
                //myBinaryCombinations[i].KiirEredmeny();
                myBinaryCombinations[i].KiirTalálatDb();
            }

            BinaryCombination bc = new BinaryCombination(30);
            bc.KiirTalálatDb();

            Console.ReadLine();
        }

    }
}
