using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobokocka
{
    class Kocka
    {
        static Random rnd = new Random();

        private int oldalakSzama;
        private int dobottErtek;

        public int OldalakSzama
        {
            get { return oldalakSzama; }
        }
        public int DobottErtek
        {
            get { return dobottErtek; }
        }

        public Kocka(int oldalakSzama)
        {
            if (oldalakSzama < 2)
            {
                oldalakSzama = 2;
            }

            this.oldalakSzama = oldalakSzama;
            this.dobottErtek = -1;
        }

        public override string ToString()
        {
            if (this.DobottErtek <1)
            {
                return $"d{OldalakSzama}: Még nem dobtunk a kockával.";
            }
            return $"d{OldalakSzama}: {this.DobottErtek}";
        }

        public void Dobas()
        {
            this.dobottErtek = rnd.Next(1, this.oldalakSzama);
        }

        private void RajzolD6()
        {
            if (this.OldalakSzama==6)
            {
                switch (this.dobottErtek)
                {
                    case 1:
                        Console.WriteLine("-----");
                        Console.WriteLine("|   |");
                        Console.WriteLine("| * |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("-----");
                        break;

                    case 2:
                        Console.WriteLine("-----");
                        Console.WriteLine("|*  |");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|  *|");
                        Console.WriteLine("-----");
                        break;

                    case 3:
                        Console.WriteLine("-----");
                        Console.WriteLine("|*  |");
                        Console.WriteLine("| * |");
                        Console.WriteLine("|  *|");
                        Console.WriteLine("-----");
                        break;

                    case 4:
                        Console.WriteLine("-----");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("|   |");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("-----");
                        break;

                    case 5:
                        Console.WriteLine("-----");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("| * |");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("-----");
                        break;

                    case 6:
                        Console.WriteLine("-----");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("|* *|");
                        Console.WriteLine("-----");
                        break;

                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ezt sajnos nem tudom kirajzolni... :(");
            }
        }

        public void Rajzol()
        {
            if (this.dobottErtek > 0)
            {


                if (this.OldalakSzama == 6)
                {
                    this.RajzolD6();
                }
                else
                {
                    Console.WriteLine("-----");
                    Console.WriteLine("|   |");
                    Console.WriteLine($"| {this.DobottErtek} |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("-----");
                }
            }
            else
            {
                Console.WriteLine("Ezt sajnos nem tudom kirajzolni... :(");
            }
        }


    }
}
