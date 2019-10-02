using System;

namespace HallgatokProgram4
{
    class Hallgato
    {
        private string nev;
        private int kor;
        private string konz;
        private int konOra;

        public Hallgato(string input)
        {
            string[] adat = input.Split(';');
            string nev = adat[0];
            int kor, konOra;
            int.TryParse(adat[1], out kor);
            string konz = adat[2];
            int.TryParse(adat[3], out konOra);

            this.SetKor(kor);
            this.SetNev(nev);
            this.SetKonz(konz);
            this.SetKonzOra(konOra);
        }

        public void SetKonzOra(int konOra)
        {
            this.konOra = konOra;
        }

        public int GetKonOra()
        {
            return this.konOra;
        }

        public string GetKonz()
        {
            return this.konz;
        }
        public void SetKonz(string konz)
        {
            this.konz = konz;
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
            return $"{nev,-14} {kor,3} éves. | Konzultánsával ({konz}) {konOra,3} órát egyeztettek eddig.";
        }


    }
}
