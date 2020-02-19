using System;
using System.Collections.Generic;
using System.Text;

namespace CalcStats
{
    class CalcStat
    {
        public List<int> Sorozat { get; private set; }
        public CalcStat(List<int> sorozat)
        {
            Sorozat = sorozat;
        }
        public int Min
        {
            get
            {
                int min = 0;

                for (int i = 1; i < Db; i++)
                {
                    if (Sorozat[i] < Sorozat[min])
                    {
                        min = i;
                    }
                }
                return Sorozat[min];
            }
        }
        public int Max
        {
            get
            {
                int max = 0;

                for (int i = 1; i < Db; i++)
                {
                    if (Sorozat[i] > Sorozat[max])
                    {
                        max = i;
                    }
                }
                return Sorozat[max];
            }
        }
        public int Szum
        {
            get
            {
                int szum = 0;
                for (int i = 0; i < Db; i++)
                {
                    szum += Sorozat[i];
                }
                return szum;
            }
        }
        public int Db { get { return this.Sorozat.Count; } }
        public double Atlag
        {
            get
            {
                return (double)Szum/(double)Db ;
            }
        }
        public void Kiertekeles()
        {
            Console.WriteLine($"A sorozat elemei: {ToString()}");
            Console.WriteLine($"    o) Minimum érték: {Min}");
            Console.WriteLine($"    o) Maximum érték: {Max}");
            Console.WriteLine($"    o) Elemek száma:  {Db}");
            Console.WriteLine($"    o) Átlag érték:   {Atlag:N2}");
        }     
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");

            for (int i = 0; i < Db-1; i++)
            {
                sb.Append($"{Sorozat[i]}, ");
            }
            sb.Append($"{this.Sorozat[Db - 1]}]");

            return sb.ToString();

        }
    }
}
