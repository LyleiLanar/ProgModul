using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyugta3
{
    class Program
    {
        static void Main(string[] args)
        {

            //blokkSzélesség: 20            

            int ar1 = 350;
            int ar2 = 680;
            int ar3 = 90;
            DateTime now = DateTime.Now;

            string nev1 = "kacsa";
            string nev2 = "csirke";
            string nev3 = "liba";

            int summa = ar1 + ar2 + ar3;

            string csillag = "********************";
            string egyenlosegjel = "====================";
            string kotojel = "--------------------";
            string alairas = "_________";


            Console.WriteLine(csillag);
            Console.WriteLine("");
            Console.WriteLine($"{"Nyugta",12}");
            Console.WriteLine(csillag);

            Console.WriteLine($"{nev1,-12}{ar1,8:C0}");
            Console.WriteLine($"{nev2,-12}{ar2,8:C0}");
            Console.WriteLine($"{nev3,-12}{ar3,8:C0}");

            Console.WriteLine(egyenlosegjel);
            Console.WriteLine($"{"Összesen:",-12}{summa,8:C0}");
            Console.WriteLine();
            Console.WriteLine(kotojel);
            Console.WriteLine($"{alairas,-9}");
            Console.WriteLine($"{now,15}");
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
