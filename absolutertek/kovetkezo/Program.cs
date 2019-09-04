using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kovetkezo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjuk meg a számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            bool pozitiv_e = szam > 0;
            bool kisebbMint10 = szam <= 9;
            if (pozitiv_e && kisebbMint10)
            {
                Console.WriteLine("A szám egyjegyű pozitív szám.");
                Console.WriteLine(szam+1);
                Console.WriteLine(szam-1);
            }
            
        }
    }
}
