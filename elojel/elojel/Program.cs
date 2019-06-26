using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elojel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjunk meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam<0)
            {
                Console.WriteLine("A szám előjele: -.");
            }
            else if(szam>0)
            {
                Console.WriteLine("A szám előjele: +.");
            }
            else
            {
                Console.WriteLine("A szám 0.");
            }
        }
    }
}
