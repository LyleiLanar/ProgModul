using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOnConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            
            Console.Write("Szia, kérlek add meg a nevedet: ");
            string name = Console.ReadLine();
                      
            Console.Write("Kérlek add meg a születési évedet is:  ");
            int szültésiÉv=2019;

            try
            {
                szültésiÉv = Convert.ToInt32(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("Nem megfelelő értéket adtál meg! Te csecsemő!");
            }

            Console.WriteLine($"A te neved: {name} és {2019 - szültésiÉv} éves vagy.\n");

            Console.WriteLine("Most kiszámlom egy 0..1 közötti szám dupláját: ");
            Console.WriteLine(Convert.ToDouble(Console.ReadLine())*3);

            Console.WriteLine("Ez kiír egy szöveget 3x, add is meg: ");
            string s = Console.ReadLine();
            Console.WriteLine(s+" "+s+" "+s);
        }
    }
}
