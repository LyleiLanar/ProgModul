using System;

namespace AltalanosHaromszog
{
    class Haromszog
    {
        private int a;
        public int A
        {
            get { return a; }
        }

        private int b;
        public int B
        {
            get { return b; }
        }

        private int c;
        public int C
        {
            get { return c; }
        }
        public Haromszog(int a, int b, int c)
        {
            if (!(a + b <= c || b + c <= a || a + c <= b))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Nem szerkeszthető a háromszög!!!");
            }
            
        }
        public double Terulet
        {
            get
            {
                double s = (this.C + this.B + this.C) / 2.0;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            }
        }
        public int Kerulet
        {
            get
            {
                return a + b + c;
            }
        }
        public override string ToString()
        {
            return $"({this.a},{this.b},{this.c}|K:{this.Kerulet}|T:{this.Terulet:N4})";
        }
    }
}
