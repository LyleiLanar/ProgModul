using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Pontok
    {
        public HashSet<Pont> PontHalmaz { get; set; }
        static private Random rnd = new Random();

        public Pontok(List<Pont> pontok)
        {
            PontHalmaz = new HashSet<Pont>();

            foreach (Pont pont in pontok)
            {
                this.PontHalmaz.Add(pont);
            }
        }

        public void Kirajzol()
        {
            foreach (Pont p in PontHalmaz)
            {
                Console.CursorLeft = (p.X+10)*2;
                Console.CursorTop = p.Y+10;
                Console.Write("*");
            }
            
        }
        
        public void RndTolt(int db)
        {
            this.PontHalmaz.Clear();
            for (int i = 0; i < db; i++)
            {
                this.PontHalmaz.Add(new Pont(rnd.Next(0, 10), rnd.Next(0, 10)));
            }
        }

        public void Animation(int db,int sec)
        {
            for (int i = 0; i < sec*10; i++)
            {
                this.RndTolt(db);
                Console.WriteLine(this);
                this.Kirajzol();
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                

            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pont p in PontHalmaz)
            {
                sb.Append(p.ToString()+" ");
            }

            return sb.ToString();
        }

 


    }
}
