using System;

namespace VonalProgram
{
    class Vonal
    {
        public enum SZINEK
        {
            piros, feher
        }

        private int hossz;
        private string nev;
        private Vonal.SZINEK szin;
        private const string NEV = "vonal";
        private const Vonal.SZINEK DEFAULT_SZIN = Vonal.SZINEK.feher;

        //ezt meg kell csinálni több színre, valamint lehessen szaggatott, valamint lehessen még eltolva.


        public Vonal() : this(1, Vonal.NEV, DEFAULT_SZIN)
        {

        }
        public Vonal(int hossz) : this(hossz, Vonal.NEV, DEFAULT_SZIN)
        {

        }

        public Vonal(int hossz, string nev, Vonal.SZINEK szin)
        {
            if (hossz < 1)
            {
                hossz = 1;
            }
            this.hossz = hossz;

            if (nev.Length < 1)
            {
                nev = Vonal.NEV;
            }
            this.nev = nev;

            this.szin = szin;
        }

        public override string ToString()
        {
            return $"{this.nev}: {this.hossz.ToString()} mm";
        }

        public void rajzol()
        {
            switch (this.szin)
            {
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case Vonal.SZINEK.piros:
                        Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            for (int i = 0; i < this.hossz; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
