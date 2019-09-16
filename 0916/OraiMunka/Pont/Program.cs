using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pont
{
    class Pont
    {
        int x, y;

        public Pont()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Pont(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public void Kiir()
        {
            Console.WriteLine($"[{X};{Y}]");
        }

        public static Pont operator+ (Pont p1, Pont p2)
        {
            return new Pont(p1.X + p2.X, p1.Y + p2.Y);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Pont p1 = new Pont(2,6);
            p1.Kiir();

            Pont p2 = new Pont(2, 5);
            p2.Kiir();

            Pont p3 = p1 + p2;
            p3.Kiir();

        }
    }
}
