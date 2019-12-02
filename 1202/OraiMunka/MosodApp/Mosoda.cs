using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosodApp
{
    class Mosoda
    {
        public List<Ruha> Ruhak { get; set; }
        private int maxRuha;

        public Mosoda()
        {
            Ruhak = new List<Ruha>();
            maxRuha = 200;
        }

        public void Bevesz(Ruha ruha)
        {
            if (Ruhak.Count<= maxRuha)
            {
                Ruhak.Add(ruha);
            }            
        }
        public void Mosas()
        {
            foreach (Ruha item in Ruhak)
            {
                item.Kimosva();
            }
        }
        public void Kiad(string tulajdonos)
        {
            int i = 0;
            while (Ruhak[i].Tulaj != tulajdonos)
            {
                i++;
            }
            Ruhak.RemoveAt(i);

        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Mosoda ruhái ({Ruhak.Count}/{maxRuha}):\r\n");

            foreach (Ruha item in Ruhak)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


    }
}
