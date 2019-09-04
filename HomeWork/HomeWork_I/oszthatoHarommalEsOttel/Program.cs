using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthatoHarommalEsOttel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adja meg a legalább három számjegyű egész számot, aminél kíváncsi, hogy osztható-e hárommal és öttel: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam>=100)
            {
                Console.WriteLine((szam%3==0 && szam%5==0) ? "A szám osztható 15-tel!": "A szám NEM osztható 15-tel!");
            }
            else
            {
                Console.WriteLine("A szám nincs legalább háromjegyű!!!");
            }
        }
    }
}
