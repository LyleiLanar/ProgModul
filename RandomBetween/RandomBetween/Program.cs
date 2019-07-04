using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérlek add meg az generálandó intervallum egyik felét (egy egész számot): ");
            int interA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kérlek add meg az generálandó intervallum egyik felét (egy egész számot): ");
            int interB = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            if (interA<interB)
            {
                Console.WriteLine($"A generált véletlenszám ebben az intervallumban: {rnd.Next(interA, interB)}");
            }
            else
            {
                Console.WriteLine($"A generált véletlenszám ebben az intervallumban: {rnd.Next(interB, interA)}");
            }

            Console.ReadLine();

        }
    }
}
