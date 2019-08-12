using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodusokkal
{
    class Program
    {
        const int SOR = 3;
        const int OSZL = 5;

        static void Main(string[] args)
        {
            
            /* lehetett volna négyzetes mátrixot is használni:
             * int[,] matrix = new int[SOR, OSZL];
             */

            int[][] matrixA = new int[SOR][];
            int[][] matrixB = new int[SOR][];

            for (int i = 0; i < SOR; i++)
            {
                matrixA[i] = new int[OSZL];
                matrixB[i] = new int[OSZL];
            }

            //feltöltés véletlenszámokkal
            Random rnd = new Random();
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    int szam = rnd.Next(-20, 31);
                    matrixA[sor][oszl] = szam;
                    szam = rnd.Next(-20, 31);
                    matrixB[sor][oszl] = szam;
                }
            }

            //kiírás: A
            /* string uzenet="\"A\" mátrix:", matrix=matrixA */
            Kiiras("\"A\" mátrix:", matrixA);
            //kiírás vége

            //kiírás: B
            /* string uzenet="\"B\" mátrix:", matrix=matrixB */
            Kiiras("\"B\" mátrix:", matrixB);
            //kiírás vége

            //összeadás: A+B
            int[][] matrixC = new int[SOR][];
            for (int i = 0; i < SOR; i++) { matrixC[i] = new int[OSZL]; }
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    matrixC[sor][oszl] = matrixA[sor][oszl] + matrixB[sor][oszl];
                }
            }
            //összeadás vége

            //eredmény kiírása: A+B
            /* itt is a Kiiras() metódust használom */
            Kiiras("\"A\" + \"B\" mátrix:",matrixC);

            //Console.WriteLine("\"A\" + \"B\" mátrix:");
            //for (int sor = 0; sor < SOR; sor++)
            //{
            //    for (int oszl = 0; oszl < OSZL; oszl++)
            //    {
            //        Console.Write($"{matrixC[sor][oszl],4}");

            //        /* ha nincs eltárolva az eredmény: */
            ////Console.Write($"{matrixA[sor][oszl] + matrixB[sor][oszl],4}");
            //    }
            //    Console.WriteLine();
            //}
            //kiírás vége


            Console.ReadLine();
        }
        
        private static void Kiiras(string uzenet, int[][] matrix)
        {
            Console.WriteLine(uzenet);
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    Console.Write($"{matrix[sor][oszl],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
