using System;

namespace InterfaceAlakzatokkal
{
    abstract class Alakzat
    {
        public Alakzat(string nev)
        {
            Nev = nev;
        }

        public String Nev { get; set; }

        public override string ToString()
        {
            return $"<{this.Nev}>";
        }

        abstract public void Rajzol();
    }

    class Sokszog : Alakzat, IPontjaiVannak, IRajzol3D
    {
        public Sokszog(string nev) : base(nev)
        {
        }

        public int Pontok() { return 5; }

        public override void Rajzol()
        {
            Console.WriteLine("Sokszog most ki lett rajzolva!");
        }

        public void rajzol3D()
        {
            Console.WriteLine("Sokszog ki lett 3D-ben rajzolva!");
        }
    }

    class Haromszog : Alakzat, IPontjaiVannak
    {
        public Haromszog(string nev) : base(nev)
        {
        }

        public int Pontok() { return 3; }

        public override void Rajzol()
        {
            Console.WriteLine("Haromszog most ki lett rajzolva!");
        }

    }
    class Kor : Alakzat
    {
        public Kor(string nev) : base(nev)
        {

        }

        public override void Rajzol()
        {
            Console.WriteLine("Kor most ki lett rajzolva!");
        }
    }

    class Kor3D : Kor, IRajzol3D
    {
        public Kor3D(string nev) : base(nev)
        {
        }

        public void rajzol3D()
        {
            Console.WriteLine("Kor3D ki lett 3D-ben rajzolva!");
        }
    }
}
