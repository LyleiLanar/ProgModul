using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Pont
    {
        int x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

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

        public string ToString()
        {
            return $"[{this.X};{this.Y}]";
        }

        static public double KetPontTavolsaga(Pont a, Pont b)
        {
            return (Math.Sqrt(Math.Pow(b.X-a.X,2)+Math.Pow(b.Y-a.Y,2)));
        }

        public double TavolsagaOrigotol()
        {
            return KetPontTavolsaga(this, new Pont());
        }
    }
}
