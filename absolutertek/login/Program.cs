using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userId_jo = "Kacsa";
            string pswd_jo = "123";

            Console.Write("Adjuk meg a felhaszálónevet: ");
            string userId = Console.ReadLine();

            Console.Write("Adjuk meg a jaelszót: ");
            string pswd = Console.ReadLine();

            if ((userId == userId_jo) && (pswd == pswd_jo))
            {
                Console.WriteLine("Beléphet az oldalra!");
            }
            else
            {
                Console.WriteLine("Nem léphet be az oldalra!");
            }
            Console.ReadLine();           
        }
    }
}
