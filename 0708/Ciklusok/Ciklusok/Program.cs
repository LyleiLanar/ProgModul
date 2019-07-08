using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tizes szorzótábla
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine();
            }
            */

            /* absolútérték
            int szamok = 10;
            Console.WriteLine($"-{szamok} és {szamok} közötti számok abszolútértéke:\n");

            for (int i = szamok; i >= -szamok; i--)
            {
                Console.WriteLine($"|{i,3}| = {Math.Abs(i),2}");
            }
            */


            /*első 10 páros szám

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i+1}. páros szám: {i*2}");
            }
            Console.ReadLine();
            */

            /* macerás 10 párps szám, érdekes dolgokkal!
            for (int i = 0, db = 1; i < 20; i = i + 2, db++) //ilyet még nem basztam!!!
            {
                Console.WriteLine($"{db}. páros szám: {i}");
            }
            */

            /* ABC irogatás
            for (int i = 65; i < 65+26; i++)
            {
                Console.Write($"{Convert.ToChar(i)} ");
                Console.WriteLine($"{Convert.ToChar(i+32)} ");
            }
            */

            /* Ez is működik!!!
            for (char i = 'A'; i < 'Z'; i++)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 0; i <= 180; i=i+5)
            {
                Console.WriteLine($"Sin({i}°) = {Math.Sin(i*Math.PI/180):N4}");
            }

            Console.ReadLine();            

            // 5tel osztható kétjegyú számot            
            //írjuk ki az összes osztóját a bekért számnak
            // fej vagy írás n darab feldobásból
        }
    }
}
