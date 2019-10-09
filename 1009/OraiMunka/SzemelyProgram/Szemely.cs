using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyProgram
{
    class Szemely
    {
        protected string nev;
        protected int kor;

        public Szemely(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }

        public void kiir()
        {
            Console.WriteLine(nev+": "+kor);
        }
    }
}
