using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Pont
    {
        public int X { get; }
        public int Y { get; }


        public Pont(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"({this.X};{this.Y})";
        }

        public override int GetHashCode()
        {
            return (this.X + this.Y).GetHashCode();
        }

        public override bool Equals(object o)
        {
            Pont that = o as Pont;

            return that != null && this.X == that.X && this.Y == that.Y;
        }


    }
}
