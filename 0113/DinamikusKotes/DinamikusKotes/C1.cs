using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinamikusKotes
{
    class C1
    {
        public void M1()
        {
            Console.Write("C1.M1 ");
            M2();
        }

        public virtual void M2()
        {
            Console.WriteLine("C1.M2");
        }
    }

    class C2:C1
    {
        public override void M2()
        {
            Console.WriteLine("C2.M2");
        }
    }
}
