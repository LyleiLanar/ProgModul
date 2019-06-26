using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetSzamElojele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adjunk meg egy számot: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Adjunk meg egy számot: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int aElojel = 1;
            int bElojel = 1;

            if (a < 0)
            {
                aElojel = 1;
            }
            else if (a > 0)
            {
                aElojel = -1;
            }
            else
            {
                aElojel = 0;
            }

            if (b < 0)
            {
                bElojel = 1;
            }
            else if (b > 0)
            {
                bElojel = -1;
            }
            else
            {
                bElojel = 0;
            }

                if (aElojel == bElojel)
                {
                    Console.WriteLine("Megegyezik!");
                }
                else
                {
                    Console.WriteLine("Nem egyezik meg!");
                }             
        }
    }
}
