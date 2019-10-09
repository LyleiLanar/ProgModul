namespace Sarkanyok
{
    class Sarkany : Allat
    {
        protected int fejekSzama;
        protected bool tuzesE;

        public Sarkany(int kor, string nev, Nemek nem, string szin, int fejekSzama, bool tuzesE) 
                      : base(kor, nev, nem, Allat.Taplalkozas.HUSEVO, szin)
        {
            this.fejekSzama = fejekSzama;
            this.tuzesE = tuzesE;
        }

        public override string ToString()
        {
            return $"{this.GetType()}: {this.nev}, {this.kor}, {this.nem}, {this.taplalkozas}, {this.fejekSzama}, {this.tuzesE}";            
        }
    }
}
