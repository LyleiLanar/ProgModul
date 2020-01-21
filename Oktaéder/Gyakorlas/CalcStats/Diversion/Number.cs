using System.Collections.Generic;
using System.Text;

namespace Diversion
{
    class Number
    {
        public List<int> Binary
        {
            get
            {
                List<int> rovidForma = new List<int>();

                for (int i = 1; i < Binary.Count; i++)
                {
                    rovidForma.Add(Binary[i]);
                }
                return rovidForma;
            }

            private set { }
        }

        public Number(int num)
        {
            Binary = new List<int>();
            ToBinaryList(num);

        }

        private void ToBinaryList(int num)
        {

            if (num == 0)
            {
                Binary.Add(0);
                return;
            }

            else
            {
                ToBinaryList(num / 2);
                Binary.Add(num % 2);
            }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            foreach (var item in Binary)
            {
                sb.Append(item);
            }

            return sb.ToString(); ;
        }


    }
}
