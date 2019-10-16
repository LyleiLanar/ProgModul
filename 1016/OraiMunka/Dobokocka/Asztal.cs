using System.Collections.Generic;
using System.Text;

namespace Dobokocka
{
    class Asztal
    {
        public List<Kocka> Kockak { get; }

        public Asztal()
        {
            Kockak = new List<Kocka>();
        }

        public void AddKocka(int oldal)
        {
            this.Kockak.Add(new Kocka(oldal));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Kocka aktKocka in Kockak)
            {
                sb.Append(aktKocka.ToString());
                sb.Append("; ");
            }

            return sb.ToString();
        }
    }
}
