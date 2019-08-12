using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetrehozasFeltoltes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a string is tömb: karakterek (char) tömbje */ 

            string szo = "Péter";
            char c = szo[0];
            Console.WriteLine("szó: " + szo);
            Console.WriteLine($"első betű: {c}");
            int utolsoIndex = szo.Length;//a hossz 5db betű, 0..4 -ig indexelhető
            c = szo[utolsoIndex-1];//IndexOutOfRangeException a -1 nlk.
            Console.WriteLine($"uccsó betű: {c}");

            /* Létrehozás, értékadás */
            //int szam1, szam2, szam3 ...

            //ha tudjuk az értékeket:
            int[] szamok1 = { 10, 20, 30 };
            Console.WriteLine($"a szamok1 egyik eleme: {szamok1[2]}");

            //ha az értékeket később adjuk meg
            int[] szamok2 = new int[3];//0..2
            szamok2[0] = 0;
            szamok2[1] = 10;
            szamok2[2] = 20;
            //szamok[3] = 20;//IndexOutOfRangeException
            Console.WriteLine($"a szamok2 egyik eleme: {szamok2[0]}");

            /* Feltöltés */
            //az első 10 db pozitív szám eltárolása
            int[] elso10Poz = new int[10];
            int length = elso10Poz.Length;
            for (int i = 0; i < length; i++)
            {
                elso10Poz[i] = i + 1;
            }

            //5db random szám. int intervallumból
            length = 5;
            int[] rnd5 = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                rnd5[i] = rnd.Next();
            }

            length = 10;
            //int[] nullaVagyEgy = new int[length];
            bool[] nullaVagyEgy = new bool[length];
            for (int i = 0; i < length; i++)
            {
                //nullaVagyEgy[i] = rnd.Next(2);
                nullaVagyEgy[i] = rnd.Next(2)==0?false:true;
            }

            length = 3;
            int[] bekert1 = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i+1}. szám: ");
                //bekert1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int[] bekert2 = new int[length+1];
            length = bekert2.Length;
            for (int i = 1; i < length; i++)
            {
                Console.Write($"{i}. szám: ");
                bekert2[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadLine();
        }
    }
}
