using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobbDimenziosTombok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Négyzetes
            int[,] negyzetes = new int[3, 4];
            int cellakSzama = negyzetes.Length;
            int sorokSzama = negyzetes.GetLength(0);
            int oszlSzama = negyzetes.GetLength(1);
            Console.WriteLine($"cellák: {cellakSzama}\nsorok: {sorokSzama}\noszlopok: {oszlSzama}");

            negyzetes[0, 0] = 9;
            negyzetes[sorokSzama-1, oszlSzama-1] = 9;

            for (int sor = 0; sor < sorokSzama; sor++)
            {
                for (int oszl = 0; oszl < oszlSzama; oszl++)
                {
                    Console.Write(negyzetes[sor, oszl] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int[][] furesz = new int[5][];
            sorokSzama = furesz.Length;

            Console.WriteLine($"sorok: {sorokSzama}");
            furesz[0] = new int[2];//különben: NullReferenceException
            Console.WriteLine($"0. sor oszlopai: {furesz[0].Length}");

            Console.WriteLine("új hosszt adok a 0. sornak:");
            for (int i = 0; i < sorokSzama; i++)
            {
                furesz[i] = new int[sorokSzama + i];
                for (int j = 0; j < furesz[i].Length; j++)
                {
                    Console.Write(furesz[i][j] + " ");
                }
                Console.WriteLine();
            }



            Console.ReadLine();
        }
    }
}
