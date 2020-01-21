using System;
using System.Collections.Generic;
using System.Text;

namespace Diversion
{
    class BinaryCombination
    {
        private int n;

        public BinaryCombination(int n)
        {
            string s = "";
            this.n = n;
            Elements = new List<string>();
            AddNewCombination(n, s);
        }
        public List<String> Elements { get; private set; }
        private void AddNewCombination(int n, string s)
        {
            if (n == 1)
            {
                Elements.Add(s + "0");
                Elements.Add(s + "1");
            }
            else
            {
                AddNewCombination(n - 1, s + "0");
                AddNewCombination(n - 1, s + "1");
            }
        }
        private List<String> GetPatternsWithNoAdjecent1()
        {
            List<String> eredmeny = new List<string>();

            foreach (string elem in Elements)
            {
                int i = 0;
                while (i < elem.Length - 1 && !(elem[i] == '1' && elem[i + 1] == '1'))
                {
                    i++;
                }

                if (i >= elem.Length - 1)
                {
                    eredmeny.Add(elem);
                }
            }
            return eredmeny;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Elements.Count - 1; i++)
            {
                sb.Append($"{Elements[i]}, ");
            }
            sb.Append($"{Elements[Elements.Count - 1]}.");

            return sb.ToString();
        }
        public void KiirEredmeny()
        {
            foreach (var item in GetPatternsWithNoAdjecent1())
            {
                Console.WriteLine(item);
            }
        }

        public void KiirTalálatDb()
        {
            Console.WriteLine($"{n} számlyegy esetében: {GetPatternsWithNoAdjecent1().Count} db.");
        }
    }
}
