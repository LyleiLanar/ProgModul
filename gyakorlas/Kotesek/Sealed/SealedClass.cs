using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotesek.Sealed
{
    class SealedClass:A
    {
        public int SValue { get; set; }

        public SealedClass(int aValue, int sValue):base(aValue)
        {
            this.SValue = sValue;
        }

        public sealed override int GetValueKesoi()
        {
            return AValue + SValue;
        }

    }
}
