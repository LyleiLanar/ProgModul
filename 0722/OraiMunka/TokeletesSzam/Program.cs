using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokeletesSzam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cel = 20;
            int szam;
            int osztokOsszege = 0; ;

            Console.Write($"Az első {cel} szám közül tökéletes szám: ");
            for (int i = 1; i < cel; i++)
            {
                szam = i;
                for (int j = 1; j <= szam / 2; j++)
                {
                    if (szam % j == 0)
                    {
                        osztokOsszege += j;
                    }
                    
                }
                if (osztokOsszege == szam)
                {
                    Console.WriteLine(szam);
                }
            }

            Console.ReadLine();
           
        }
    }
}
