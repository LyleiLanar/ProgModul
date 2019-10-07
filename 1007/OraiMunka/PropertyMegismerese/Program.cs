namespace PropertyMegismerese
{
    class Program
    {
        class Osztaly
        {
            private int kor;
            private string nev;


            //hatterben, valamint más nyelvekben, például Java.
            public int GetKor()
            {
                return this.kor;
            }
            public void SetKor(int kor)
            {
                this.kor = kor;
            }
            public string GetNev()
            {
                return this.nev;
            }
            public void SetNev(string nev)
            {
                this.nev = nev;
            }

            /* ---- C# megoldas: PROPERTY ---- */
            
            //TELJES PROPERTY
            private int myKor;

            public int MyKor
            {
                get { return myKor; }
                set { myKor = value; }
            }

            //AUTOMATIKUS PROPERTY
            public int MyProperty { get; set; }

        }

        static void Main(string[] args)
        {

            Osztaly o = new Osztaly();

        }
    }
}
