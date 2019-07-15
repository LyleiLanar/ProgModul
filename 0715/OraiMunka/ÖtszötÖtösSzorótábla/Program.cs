using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖtszötÖtösSzorótábla
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 40;

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size ; j++)
                {
                    Console.Write($"{i*j,4} ");
                }

                Console.WriteLine();
            }


        }
    }
}
