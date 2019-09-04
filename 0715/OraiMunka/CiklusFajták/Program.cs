using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiklusFajták
{
    class Program
    {      
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }

            Console.WriteLine();
            int j = 0;
            while (j<10)
            {
                Console.Write(j);
                j++;
            }

            Console.WriteLine();
            int k = 0;

            do
            {                
                Console.Write(k);
                k++;
            } while (k<10);

            Console.ReadLine();
        }
    }
}
