using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace PeldaEGy
{


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

        /*EXPLICIT*/
        //int IComparable<Ember>.CompareTo(Ember that)
        //{
        //    return this.Kor.CompareTo(that.Kor);

        //}

        //public int CompareTo(Object obj)
        //{
        //    Ember that = (Ember)obj;

        //    //if (this.Kor < that.Kor) { return -1; }
        //    //else if (this.Kor < that.Kor) { return 0; }
        //    //else { return 1; }

        //    return this.Kor - that.Kor;
        //

    }

    class NevComparer : IComparer<Ember>
    {
        public int Compare(Ember x, Ember y)
        {
            //return string.Compare(x.Nev, y.Nev, true, CultureInfo.CurrentCulture);
            return string.Compare(x.Nev,y.Nev,  CultureInfo.CurrentCulture, CompareOptions.Ordinal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int[] szamok = { 3, 10, 5 };
            Array.Sort(szamok);

            foreach (var item in szamok)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Ember e2 = new Ember("Papa", 31);
            Ember e1 = new Ember("Mama", 34);

            Ember[] emberek = { e1, e2 };
            Array.Sort(emberek);
            // Array.Sort(emberek, new NevComparer());

            Array.Sort(emberek, Ember.RendezByNev);

            foreach (var item in emberek)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
