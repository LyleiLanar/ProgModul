using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static int statInt = 2;

        static void Main(string[] args)
        {
            
            int nemStatInt = 5;
            //metodus();

            Console.WriteLine($"statInt=" + statInt);
            Console.WriteLine($"nemStatInt=" + nemStatInt);
            Program prg = new Program();                       
            prg.nemStatMetodus();            

        }

        void nemStatMetodus()
        {
            Console.WriteLine("Nem statikus metodus meghivasa");
            statInt = 10;
        }


        private static void statMetodus()
        {
            Console.WriteLine("Statikus metodus meghivasa");
            statInt = 10;
        }
    }
}
