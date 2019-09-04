using System;

namespace Osszegzes_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int szum = 0;
            int szam;
            for (int i = 0; i < n; i++)
            {
                bool ervenyes=true;

                do
                {
                    ervenyes = Int32.TryParse(Console.ReadLine(), out szam);

                } while (!ervenyes);

                szum += szam;
            }

            Console.WriteLine(szum);
            Console.ReadLine();
        }

    }
}
