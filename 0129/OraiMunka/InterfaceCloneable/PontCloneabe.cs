using System;

namespace InterfaceCloneable
{
    class PontCloneabe : ICloneable
    {
        public PontCloneabe(int x, int y, String nev)
        {
            X = x;
            Y = y;
            info = new Pontleiras(nev);
        }
        public PontCloneabe(int x, int y) : this(x, y, "üres") {; }        

        public int X { get; set; }
        public int Y { get; set; }

        public Pontleiras info;

        public override string ToString()
        {
            return $"{info.Nev}({X};{Y})";
        }

        public object Clone()
        {
            return new PontCloneabe(this.X, this.Y);
        }
    }
}
