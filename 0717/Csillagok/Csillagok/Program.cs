using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csillagok
{
    class Program
    {
        static void Main(string[] args)
        {
            int sorokSzama = 20;

            for ( int i = 1; i <= sorokSzama; i++)
            {
                int csillagokSzama=(i*2)+1;

                for (int j = 0; j < csillagokSzama; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
