using System;

namespace Mozi
{
    class Terem
    {
        public Ulohely[][] Helyek { get; }

        public Terem(string input)
        {
            string[] sorok = input.Split('\n');

            for (int i = 0; i < sorok.Length; i++)
            {
                sorok[i] = sorok[i].Substring(sorok[i].IndexOf(':')+2);
                if (i!=sorok.Length-1)
                {
                    sorok[i] = sorok[i].Remove(sorok[i].Length - 1, 1);
                }                
            }

            Helyek = new Ulohely[sorok.Length][];

            for (int i = 0; i < sorok.Length; i++)
            {
                Helyek[i] = new Ulohely[sorok[i].Length];

                for (int j = 0; j < sorok[i].Length; j++)
                {
                    Helyek[i][j] = new Ulohely(sorok[i][j]);
                }
            }

        }
    
        public void Kirajzol()
        {
            for (int i = 0; i < Helyek.Length; i++)
            {
                for (int j = 0; j < Helyek[i].Length; j++)
                {
                    Console.Write(Helyek[i][j].GetSzimbolum()+" ");
                }
                Console.WriteLine();
            }
        }
    }
}