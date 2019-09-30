using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] adatok = File.ReadAllLines("hallgatok.txt",Encoding.Default);

            Hallgato[] hallgatok = new Hallgato[adatok.Length];

            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i] = new Hallgato(adatok[i]);    
            }

            for (int i = 0; i < hallgatok.Length; i++)
            {
                hallgatok[i].Kiir();
            }
            Console.ReadLine();
        }
    }
}
