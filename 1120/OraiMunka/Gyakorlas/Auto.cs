using System;

namespace Gyakorlas
{
    class Auto
    {
        public Auto() : this("ismeretlen", "ismeretlen", -1)
        {
            ;
        }

        /// <summary>
        /// Egy általános autót hoz létre, ahol csak a márkát ismerjük.
        /// </summary>
        /// <param name="marka">Ez az auto márkája.</param>
        public Auto(string marka) : this(marka, "ismeretlen", -1)
        {
            ;
        }


        public Auto(string marka, string rendszam) : this(marka, rendszam, -1)
        {
            ;
        }

        public Auto(string marka, string rendszam, int kor)
        {
            Marka = marka;
            Rendszam = rendszam;
            Kor = kor;
        }


        public string Marka { get; }
        public string Rendszam { get; }
        public int Kor { get; }



        public override string ToString()
        {
            return $"<Marka: {Marka}, Rendszam: {Rendszam}, Kor: {Kor}>";
        }

    }
}
