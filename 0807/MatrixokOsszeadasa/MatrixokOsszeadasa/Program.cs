using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixokOsszeadasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //létrehozás, 0-val inicializálás
            const int SOR = 3;
            const int OSZL = 5;
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
            Console.WriteLine("\"A\" mátrix:");
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    Console.Write($"{matrixA[sor][oszl],4}");
                }
                Console.WriteLine();
            }
            //kiírás vége

            //kiírás: B
            Console.WriteLine("\"B\" mátrix:");
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    Console.Write($"{matrixB[sor][oszl],4}");
                }
                Console.WriteLine();
            }
            //kiírás vége

            //összeadás: A+B
            int[][] matrixC = new int[SOR][];
            for (int i = 0; i < SOR; i++){ matrixC[i] = new int[OSZL]; }
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    matrixC[sor][oszl] = matrixA[sor][oszl] + matrixB[sor][oszl];
                }
            }
            //összeadás vége

            //eredmény kiírása: A+B
            Console.WriteLine("\"A\" + \"B\" mátrix:");
            for (int sor = 0; sor < SOR; sor++)
            {
                for (int oszl = 0; oszl < OSZL; oszl++)
                {
                    Console.Write($"{matrixC[sor][oszl], 4}");

                    /* ha nincs eltárolva az eredmény: */
                    //Console.Write($"{matrixA[sor][oszl] + matrixB[sor][oszl],4}");
                }
                Console.WriteLine();
            }
            //kiírás vége


            Console.ReadLine();
        }
    }
}
