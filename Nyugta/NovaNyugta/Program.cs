using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaNyugta
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Házi feladat optimalizálni!!          
             */


            int blokkSzelesseg = 20;
            int tetel1 = 350;
            int tetel2 = 680;
            int tetel3 = 90;
            int summa = tetel1 + tetel2 + tetel3;
            int csillagokHossza = 20;

            string csillag = "********************";
            string egyenlosegjel = "====================";
            string kotojel = "--------------------";
            string alairas = "_________";


            Console.WriteLine(csillag);
            Console.WriteLine("");
            Console.WriteLine($"{"Nyugta",12}");
            Console.WriteLine(csillag);
            Console.WriteLine($"{"Tétel 1:",-8}{tetel1,12:C0}");
            Console.WriteLine($"{"Tétel 2:",-8}{tetel2,12:C0}");
            Console.WriteLine($"{"Tétel 3:",-8}{tetel3,12:C0}");
            Console.WriteLine(egyenlosegjel);
            Console.WriteLine($"{"Összesen",-9}{summa,11:C0}");
            Console.WriteLine();
            Console.WriteLine(kotojel);
            Console.WriteLine($"{alairas,-9}");
            Console.WriteLine($"{"Dátum",7}");
            Console.WriteLine(kotojel);
            Console.WriteLine();
            Console.WriteLine($"{alairas,20}");
            Console.WriteLine($"{"Név",17}");
            Console.WriteLine(kotojel);
            Console.WriteLine($"{"CÉG",11}");
            Console.WriteLine(csillag);
            
        }
    }
}
