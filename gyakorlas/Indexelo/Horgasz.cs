using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexelo
{
    class Horgasz
    {
        protected List<Hal> zsak = new List<Hal>();
        protected double zsak_suly = 0;

        public bool ZsakbaBefer(Hal hal)
        {
            
            if (hal == null) throw new NullReferenceException("A hal nem lehet null!");
            if (hal.Suly +zsak_suly>30) return false;

            return true;
        }
        public void ZsakbaRak(Hal hal)
        {
            if (ZsakbaBefer(hal))
            {
                zsak.Add(hal);
                zsak_suly += hal.Suly;
            }
            else throw new ArgumentException("Nem fér bele a hal a zsákba!");
            
        }

        public Hal Zsak_eleme(int index)
        {
            if ( index<0 || index>=zsak.Count)
            {
                throw new IndexOutOfRangeException("Nincs ennyi hal a zsákban!");
            }

            return zsak[index];
        }

        public void CsereHal(int index, Hal hal)
        {
            if (index < 0 || index >= zsak.Count)
            {
                throw new IndexOutOfRangeException("Nincs ennyi hal a zsákban!");
            }

            if (ZsakbaBefer(hal))
            {
                zsak[index] = hal;
                zsak_suly += hal.Suly;
            }

        }
    }
}
