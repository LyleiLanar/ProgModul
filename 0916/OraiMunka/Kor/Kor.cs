using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kor
{
    class Kor
    {
        int radius;
        Pont center;

        public int Radius { get => radius; set => radius = value; }
        internal Pont Center { get => center; set => center = value; }

        public Kor(int radius, Pont center)
        {
            this.Radius = radius;
            this.Center = center;
        }
        public Kor(int radius, int x, int y)
        {
            this.Radius = radius;
            this.Center = new Pont(x,y);
        }

        override public string ToString()
        {           
           return $"{this.Center.ToString()} R={this.Radius}";
        }
        
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }     

    }
}
