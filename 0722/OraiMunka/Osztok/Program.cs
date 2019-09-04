using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztok
{
    class Program
    {
        static void Main(string[] args)
        {
            bool feltetel = true;
            int szam;
            do
            {
                szam = 99;
            } while (!feltetel);
            

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    Console.Write($"{i}, ");
                }
                
            }
            Console.WriteLine(szam);
        }
    }
}
