using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizmus
{
    abstract class Alakzat
    {

        abstract public double Terulet();
        public void KiirTerulet() //itt kiiratjuk a területet, ami viszont abstract, és emiatt a dinamikus típus szerinti metódus fog lefutni.
        {
            Console.WriteLine(ToString());
        }

        virtual public void Kiir()
        {
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return $"Alakzat(T:{this.Terulet()})";
        }      
    }
}
