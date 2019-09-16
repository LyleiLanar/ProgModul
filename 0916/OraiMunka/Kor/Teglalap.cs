using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Teglalap
    {
        Pont center;
        int a, b;

        //konstruktorok
        public Teglalap(Pont center, int a, int b)
        {
            setA(a);
            setB(b);
            setCenter(center);
        }
        public Teglalap(int x, int y, int a, int b)
        {
            setCenter(x, y);
            setA(a);
            setB(b);
        }

        //getterek, setterek
        public void setA(int a)
        {
            if (a>0)
            {
                this.a = a;
            }
            else
            {
                this.a = 1;
            }
        }
        public void setB(int b)
        {
            if (b > 0)
            {
                this.b = b;
            }
            else
            {
                this.b = 1;
            }
        }
        public int getA()
        {
            return this.a;
        }
        public int getB()
        {
            return this.b;
        }
        public void setCenter(int x, int y)
        {
            this.center = new Pont(x, y);
        }
        public void setCenter(Pont center)
        {
            this.center = center;
        }
        public Pont getCenter()
        {
            return this.center;
        }

        public override string ToString()
        {
            return $"a={this.a} b={this.b} {this.center.ToString()}";
        }
    }
}
