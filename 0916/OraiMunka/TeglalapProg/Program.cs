using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeglalapProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Teglalap t1 = new Teglalap();
            t1.Kiir();

            Teglalap t2 = new Teglalap();
            t2.a = 6;
            t2.b = 7;
            t2.Kiir();
        }
        

    }
}
