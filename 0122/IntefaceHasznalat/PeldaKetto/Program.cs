using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace PeldaKetto
{


    class Nevsor : IEnumerable<Ember>
    {

        /*Itt még tömb volt, de aztén áttérünk a listára*/
        //private Ember[] emberek;
        //public Nevsor()
        //{
        //    emberek = new Ember[4];

        //    emberek[0] = new Ember("Péter", 21);
        //    emberek[1] = new Ember("Pál", 22);
        //    emberek[2] = new Ember("Petra", 23);
        //    emberek[3] = new Ember("Kálmán", 24);
        //}

        //public Ember[] GetEmberek()
        //{
        //    return emberek;
        //}


        List<Ember> emberek = new List<Ember>();

        public Nevsor()
        {
            emberek.Add(new Ember("Péter", 21));
            emberek.Add(new Ember("Pál", 22));
            emberek.Add(new Ember("Petra", 23));
            emberek.Add(new Ember("Kálmán", 24));
        }

        public IEnumerator<Ember> GetEnumerator()
        {
            return emberek.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return emberek.GetEnumerator();
        }

        //public List<Ember> GetEmberek()
        //{
        //    return emberek;
        //}


    }

    class Ember : IComparable<Ember>
    {
        static public IComparer<Ember> RendezByNev
        {
            get
            {
                return new NevComparer();
            }
        }
        public Ember(string nev, int kor)
        {
            Kor = kor;
            Nev = nev;
        }
        public string Nev { get; }
        public int Kor { get; }


        public override string ToString()
        {
            return $"<Nev:{Nev}, Kor:{Kor}>";
        }

        /*GENERIKUS*/
        public int CompareTo(Ember that)
        {
            return this.Kor.CompareTo(that.Kor);
        }
    }

    class NevComparer : IComparer<Ember>
    {
        public int Compare(Ember x, Ember y)
        {
            //return string.Compare(x.Nev, y.Nev, true, CultureInfo.CurrentCulture);
            return string.Compare(x.Nev, y.Nev, CultureInfo.CurrentCulture, CompareOptions.Ordinal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nevsor ns = new Nevsor();
            // Ember[] emberek = ns.GetEmberek();
            //List<Ember> emberek = ns.GetEmberek();

            //foreach (var item in emberek)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //emberek[3] = new Ember("Köcsög", 120);

            //// Ember[] emberek2 = ns.GetEmberek();
            //List<Ember> emberek2 = ns.GetEmberek();

            //foreach (var item in emberek2)
            //{
            //    Console.WriteLine(item);
            //}

            foreach (var item in ns)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
