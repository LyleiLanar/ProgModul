using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobokocka
{
    class Program
    {
        static void Main(string[] args)
        {
            Asztal a = new Asztal();

            a.AddKocka(6);
            a.AddKocka(10);
            a.AddKocka(12);

            Console.WriteLine(a.ToString());
            Console.WriteLine();
            Console.WriteLine("Dobjunk minden kockával:");

            foreach (Kocka actKocka in a.Kockak)
            {
                actKocka.Dobas();
                Console.WriteLine(actKocka.ToString());
                actKocka.Rajzol();
            }
        }
    }
}
