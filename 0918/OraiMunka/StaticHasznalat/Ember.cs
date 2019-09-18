using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticHasznalat
{
    class Ember
    {
        //osztályszintű cuccok
        static private int korhatar;
        static private int db=0;               

        static public void SetKorhatar(int korhatar)
        {
            Ember.korhatar = korhatar;
        }
        static public int GetKorhatar()
        {
            return Ember.korhatar;
        }
        
        static private int GetDb()
        {
            return Ember.db;
        }
        static public string Statisztika()
        {
            return $"{GetDb()} ember lett kreálva.";
        }

        //példányszintű cuccok
        private int kor;
        private string nev;

        public void SetKor(int kor)
        {
            if (kor<korhatar)
            {
                kor = korhatar;
            }
            this.kor = kor;
        }
        public void SetNev(string nev)
        {
            if (nev == ""|| nev == null)
            {
                nev = "noname";
            }
            this.nev = nev;
        }
        public int GetKor()
        {
            return this.kor;
        }
        public string GetNev()
        {
            return this.nev;
        }

        public Ember() : this(18,"") { }        
        public Ember(int kor, string nev)
        {
            SetKor(kor);
            SetNev(nev);
            Ember.db++;
        }

        public override string ToString()
        {
            return $"<{this.nev}:{this.kor} éves>";
        }        
        
    }
}
