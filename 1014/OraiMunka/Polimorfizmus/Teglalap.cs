using System;

namespace Polimorfizmus
{
    class Teglalap : Alakzat
    {
        private double a, b;
        public Teglalap(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public void SetA(double a)
        {
            this.a = a;
        }
        public void SetB(double b)
        {
            this.b = b;
        }
        
        public override double Terulet()
        {
            return a * b;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }




}

