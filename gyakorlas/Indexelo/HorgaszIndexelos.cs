using System;

namespace Indexelo
{
    class HorgaszIndexelos : Horgasz
    {

        // az indexelő segítségével 
        public Hal this[int index]
        {
            get
            {

                if (index < 0 || index >= zsak.Count)
                {
                    throw new IndexOutOfRangeException("Nincs ennyi hal a zsákban!");
                }
                return zsak[index];
            }

            set
            {
                if (value == null) throw new NullReferenceException("a hal nem lehet null");
                if (index < 0 || index >= zsak.Count)
                {
                    throw new IndexOutOfRangeException("Nincs ennyi hal a zsákban!");
                }
                if (ZsakbaBefer(value))
                {
                    zsak[index] = value;
                    zsak_suly += value.Suly;
                }
            }
        }

        

    }
}
