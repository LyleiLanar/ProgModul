using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzemelyProgram
{
    class Alkalmazott : Szemely
    {
        private int munkaEv;

        public Alkalmazott(string nev, int kor, int munkaEv): base(nev, kor)
        {
            this.munkaEv = munkaEv;
        }
         public void kiir()
        {
            
            //base.kiir(); //OMG
            Console.WriteLine(base.nev + ": " + base.kor+", "+munkaEv);
        }

    }
}
