namespace Sakk
{
    class Figura
    {
        public enum SZINEK
        {
            fekete,feher
        }

        private SZINEK szin;
        private int x;
        private int y;
        private char fajta='F';


        public Figura(SZINEK szin, int x, int y)
        {
            this.szin = szin;
            this.x = x;
            this.y = y;

        }

        public void Mozog(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
    }
}
