using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotoGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i < 14; i++)
            {
                Console.Write($"{i,3}");
            }

            Console.WriteLine($"{"13+1",5}");

            for (int i = 1; i < 15; i++)
            {
                switch (rnd.Next(0, 3))
                {

                    case 0:
                        Console.Write($"{"X",3}");
                        break;

                    case 1:
                        Console.Write($"{"1",3}");
                        break;

                    case 2:
                        Console.Write($"{"2",3}");
                        break;

                    default:
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
