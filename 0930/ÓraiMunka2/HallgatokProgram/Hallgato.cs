using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HallgatokProgram
{
    class Hallgato
    {
        private string nev;
        private int kor;                

        public Hallgato(string nev, int kor)
        {
            this.SetKor(kor);
            this.SetNev(nev);
        }

        public Hallgato(string input)
        {
            string[] adat = input.Split(';');
            string nev = adat[0];
            int kor;
            int.TryParse(adat[1], out kor);

            this.SetKor(kor);
            this.SetNev(nev);
        }

        public string GetNev()
        {
            return this.nev;
        }
        public void SetNev(string nev)
        {
            this.nev = nev;
        }

        public int GetKor()
        {
            return this.kor;
        }        
        public void SetKor(int kor)
        {
            this.kor = kor;
        }        

        public void Kiir()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Név: {nev}   kor: {kor}";
        }


    }
}
