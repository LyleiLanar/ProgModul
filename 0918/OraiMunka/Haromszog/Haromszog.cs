using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    class Haromszog
    {
        private int a, b, c;

        public Haromszog(int a, int b, int c)
        {
            setA(a);
            setB(b);
            setC(c);
        }

        public Haromszog()
        {
            setA(1);
            setB(1);
            setC(1);
        }

        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }
        public int getC()
        {
            return this.c;
        }
        public void setA(int a)
        {
            if (a<1)
            {
                a = 1;
            }
            this.a = a;
        }
        public void setB(int b)
        {
            if (b < 1)
            {
                b = 1;
            }
            this.b = b;
        }
        public void setC(int c)
        {
            if (c < 1)
            {
                c = 1;
            }
            this.c = c;
        }        

        public int kerulet()
        {
            return a + b + c;
        }
        public double terulet()
        {
            double s = ((double)a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public override string ToString()
        {
            return $"<{this.a},{this.b},{this.c}>";
        }



    }
}
