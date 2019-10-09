namespace Sarkanyok
{
    class Allat
    {
        public enum Nemek { NOSTENY, HIM }
        public enum Taplalkozas { HUSEVO, NEVENYEVO, MINDENEVO }

        protected int kor;
        protected string nev;
        protected Nemek nem;
        protected Taplalkozas taplalkozas;
        protected string szin;

        public Allat(int kor, string nev, Nemek nem, Taplalkozas taplalkozas, string szin)
        {
            this.kor = kor;
            this.nev = nev;
            this.nem = nem;
            this.taplalkozas = taplalkozas;
        }

        public override string ToString()
        {
            return $"{this.GetType()}: {this.nev}, {this.kor}, {this.nem}, {this.taplalkozas}";
        }

        public  void Eszik() { }
        public void Alszik() { }

    }
}
