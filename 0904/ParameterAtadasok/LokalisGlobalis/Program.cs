using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokalisGlobalis
{
    class Program
    {
        static int globClass = -5;

        static void Main(string[] args)
        {

            int lokMain = 1;
            for (int i = 0; i < 10; i++)
            {
                lokMain = i;
            }

            metodus(5);
            lokMain = globClass;            
        }

        static void metodus(int lokElj)
        {
            int globClass = 10;
            lokElj = 12;
            Console.WriteLine($"globClass: {globClass}");
        }
    }
}
