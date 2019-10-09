namespace Sarkanyok
{
    class SarkanyMagus : Sarkany
    {
        private int ismertVarazslatokSzama;

        public SarkanyMagus(int kor, string nev, Nemek nem, string szin, int fejekSzama, bool tuzesE, int ismertVarazslatokSzama)
                           : base(kor, nev, nem, szin, fejekSzama, tuzesE)
        {
            this.ismertVarazslatokSzama = ismertVarazslatokSzama;
        }

        public override string ToString()
        {
            return $"{this.GetType()}: {this.nev}, {this.kor}, {this.nem}, {this.taplalkozas}, {this.fejekSzama}, {this.tuzesE}, {this.ismertVarazslatokSzama}";
        }

    }
}
