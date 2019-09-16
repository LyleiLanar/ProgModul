using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Ember
    {
        public enum nemek
        {
            FERFI, NO
        }

        private nemek nem;
        private string nev;
        private int kor;

        internal nemek Nem { get => nem; set => nem = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }

        public Ember(nemek nem, string nev, int kor)
        {
            this.Nem = nem;
            this.Nev = nev;
            this.Kor = kor;
        }
    }
}
