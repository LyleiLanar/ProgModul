namespace AltalanosHaromszog
{
    class EgyenloSzaruHaromszog : Haromszog
    {
        private int a, szar;
        

        public EgyenloSzaruHaromszog(int alap, int szar) : base(alap, szar, szar)
        {
            this.a = this.A;
            this.szar = this.B;
        }        

        public override string ToString()
        {
            return $"({this.a},{this.szar})|K:{this.Kerulet}|T:{this.Terulet:N4})";
        }

    }
}
