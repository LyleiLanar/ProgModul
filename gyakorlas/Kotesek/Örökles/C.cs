using System;

namespace Kotesek
{
    class C : B
    {
        public int CValue { get; set; }

        //paraméteres konstruktor, ami majd az ősosztály kétparaméteres konstruktorát hívja.
        public C(int aValue, int bValue, int cValue) : base(aValue, bValue)
        {
            Console.WriteLine("C, parameteres konstruktor");
            CValue = cValue;
        }

        //paraméter nélküli konstruktor, ami majd a paraméternélkülit fogja hívni az ősosztálya paraméter nélküli konstruktorát fogja hívni.
        public C()
        {
            Console.WriteLine("C, parameter NÉLKÜLI konstruktor");
            CValue = 0;
        }

        //az eredeti metódus elfedése történik
        new public int GetValueKorai()
        {
            return AValue + Bvalue + CValue;
        }

        // az eredeti metódus felülírása történik
        public override int GetValueKesoi()
        {
            return AValue + Bvalue + CValue;
        }
    }
}
