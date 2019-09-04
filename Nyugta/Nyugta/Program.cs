using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyugta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //vakacio();
            blokk();

            Console.ReadLine();
        }

        static void vakacio()
        {

            string szo = "VAKÁCIÓ";
            const int tav = 7; //szo.Length;
            int szoHossz = szo.Length;            

            Console.WriteLine($"{"Ó",tav}");
            Console.WriteLine($"{"IÓ",tav}");
            Console.WriteLine($"{"CIÓ",tav}");
            Console.WriteLine($"{"ÁCIÓ",tav}");
            Console.WriteLine($"{"KÁCIÓ",tav}");
            Console.WriteLine($"{"AKÁCIÓ",tav}");
            Console.WriteLine($"{"VAKÁCIÓ",tav}");

        }

        static void blokk()
        {
            int blokkSzelesseg = 20;
            int tetel1 = 350;
            int tetel2 = 680;
            int tetel3 = 90;
            Console.WriteLine("********************");
            Console.WriteLine("");
            Console.WriteLine($"{"Nyugta",12}");

            Console.WriteLine("********************");
            Console.WriteLine($"Tétel 1: {tetel1,7} Ft");
            Console.WriteLine($"Tétel 2: {tetel2,7} Ft");
            Console.WriteLine($"Tétel 3: {tetel3,7} Ft");
            Console.WriteLine("====================");
            Console.WriteLine("Összesen: 1120 Ft");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.WriteLine($"________");
            Console.WriteLine(" Dátum");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.WriteLine($"{"________",20}");
            Console.WriteLine("              Név");
            Console.WriteLine("--------------------");
            Console.WriteLine($"        {"CÉG"}");
            Console.WriteLine("********************");
        }
    }
}