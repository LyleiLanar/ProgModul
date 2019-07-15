using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KettoHaromNegy
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i <= 4; i++)
            {
                for (int j = 2; j <= 4; j++)
                {
                    for (int k = 2; k <= 4; k++)
                    {
                        if (i!=j && j!=k && i!=k)
                        {
                            Console.Write($"{string.Concat(i, j, k)} ");
                            Console.WriteLine();
                        }                        
                    }
                }
            }
            Console.ReadLine();
        }        
    }
}
