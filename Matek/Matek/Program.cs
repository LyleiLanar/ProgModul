using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //itt gyorsan megnézzük a matematikai függvényeket:
            string cpi = "\u03c0";
            
            Console.WriteLine("A {0} értéke: {1}",cpi, Math.PI);
            Console.WriteLine("Az e értéke: {0}", Math.E);

            int num = -5;
            Console.WriteLine("{0} abszolútértéke: {1}",num, Math.Abs(num) );
            num = 5;
            Console.WriteLine("{0} négyzetegyöke: {1}", num, Math.Sqrt(num));
            Console.WriteLine("Pi/4 értéke kerekítve négy tizedesjegyig: {0:N4}", Math.PI/4);
            Console.WriteLine("sin(pi/4) radiánban: {0}", Math.Sin(Math.PI/4));
            int fok = 45;
            Console.WriteLine("sin(45°): {0}", Math.Sin(Math.PI * fok / 180.0));
            Console.WriteLine("négyzetgyök2/2: {0}", Math.Sqrt(2)/2);
            Console.WriteLine("Kettő a nyolcadikon: {0}", Math.Pow(2,8));
            Console.WriteLine("Maximum függvény: {0}", Math.Max(1,54));
            Console.WriteLine("Mimimum függvény: {0}", Math.Min(1, 54));


            Console.ReadLine();
        }
    }
}
