using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tulcsordulas();
            Adatbevitel();

            Console.ReadLine();
        }

        static void Tulcsordulas()
        {
            int i = int.MaxValue;
            i = i / 2;
            i++;

            long l = i * 2;
            Console.WriteLine(l);

            i = int.MaxValue;
            i = i / 2;
            i++;
            l = (long)i * 2;

            Console.WriteLine(l);
        }
        static void Adatbevitel()
        {
            string szöveg;
            szöveg = Console.ReadLine();
            Console.WriteLine(szöveg);         
        }   
    }
}
