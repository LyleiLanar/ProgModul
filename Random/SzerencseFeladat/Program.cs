using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzerencseFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine(rnd.Next(10,100));

            int rszam = rnd.Next(45);

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine((rnd.Next(45) * 2) + 11);
            }

            Console.WriteLine((rnd.Next(45) * 2) + 11);
            Console.WriteLine(rnd.Next((45) * 2) + 11);



        }

    }
}
