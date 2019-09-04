using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ertekadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("a={0}, b={1}, a+=b után a={2}, b={3},",a=8,b=3,a+=b,b);
            Console.WriteLine("a={0}, b={1}, a-=b után a={2}, b={3},", a = 8, b = 3, a -= b, b);
            Console.WriteLine("a={0}, b={1}, a*=b után a={2}, b={3},", a = 8, b = 3, a *= b, b);
            Console.WriteLine("a={0}, b={1}, a/=b után a={2}, b={3},", a = 8, b = 3, a /= b, b);
            Console.WriteLine("a={0}, b={1}, a%=b után a={2}, b={3},", a = 8, b = 3, a %= b, b);
            Console.WriteLine("a={0}, b={1}, a++ után a={2}, b={3},", a = 8, b = 3, a++, b);

            Console.WriteLine("a={0}, b={1}, ++a után a={2}, b={3},", a = 8, b = 3, ++a, b);

            a = 8;
            b = a++ + ++a;
            //= 
            Console.WriteLine(b);

            

        }
    }
}
