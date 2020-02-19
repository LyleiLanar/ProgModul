using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaromszogProgram
{
    public class Haromszog
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public Haromszog(double a, double b, double c)
        {
            if (a + b > c && b + c > a && a + c > b)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else { throw new Exception("Ez a háromszög nem létezik."); }
        }

        public double Kerulet()
        {
            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
