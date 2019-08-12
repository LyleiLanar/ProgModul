using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI_Torpedo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hajo = { 2, 3, 4 };//ezt kell véletlen generálni...
            bool[] talalatok = new bool[3];
            int talalat = 0;
            do
            {
                Console.Write("tipp: ");
                int tipp;
                int.TryParse(Console.ReadLine(), out tipp);
                int length = hajo.Length;
                
                for (int i = 0; i < length; i++)
                {
                    if (tipp == hajo[i] && !talalatok[i])
                    {
                        talalat++;
                        talalatok[i] = true;
                        Console.WriteLine($"Talált! (3/{talalat})");
                    }  
                }
            } while (talalat < 3);
            Console.WriteLine("A hajó elsüllyedt!");

            Console.ReadLine();
        }
    }
}
