using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TizezerOsztoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10007;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
