using System;
using System.IO;
using System.Text;

namespace Kiralynok_OKJ
{
    class Tabla
    {
        private char[,] T;
        private char uresCella;


        public static void FajlbaIr()
        {
            

            if (File.Exists("tablak64.txt"))
            {
                File.Delete("tablak64.txt");
            }

            int tombMeret = 64;
            Tabla[] tablak64 = new Tabla[tombMeret];

            StringBuilder sb = new StringBuilder();
            //string text = "";
            for (int i = 0; i < tombMeret; i++)
            {
                tablak64[i] = new Tabla('*');
                tablak64[i].Elhelyez(i + 1);
                sb.Append(tablak64[i].ToString());
                sb.AppendLine();
                //text += tablak64[i].ToString() + "\r\n";
            }
            File.WriteAllText("tablak64.txt", sb.ToString());
        }

        public Tabla(char uresCella)
        {
            this.T = new char[8, 8];
            this.uresCella = uresCella;

            for (int i = 0; i < this.T.GetLength(0); i++)
            {
                for (int j = 0; j < this.T.GetLength(1); j++)
                {
                    this.T[i, j] = this.uresCella;
                }
            }
        }
        public void Megjelenit()
        {

            Console.WriteLine(this.ToString());
            //for (int i = 0; i < this.T.GetLength(0); i++)
            //{
            //    for (int j = 0; j < this.T.GetLength(1); j++)
            //    {
            //        Console.Write(this.T[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
        public void Elhelyez(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                bool ures = false;
                int x, y;

                while (!ures)
                {
                    x = rnd.Next(0, this.T.GetLength(1));
                    y = rnd.Next(0, this.T.GetLength(0));

                    if (this.T[x, y] == this.uresCella)
                    {
                        ures = true;
                        this.T[x, y] = 'K';
                    }
                }
            }
        }
        public bool UresOszlop(int y)
        {
            int i = 0;

            while (i < this.T.GetLength(0) && !(this.T[i, y] == 'K'))
            {
                i++;
            }

            if (i < this.T.GetLength(0))
            {
                return true;
            }
            return false;
        }
        public bool UresSor(int x)
        {
            int j = 0;

            while (j < this.T.GetLength(0) && !(this.T[x, j] == 'K'))
            {
                j++;
            }

            if (j < this.T.GetLength(0))
            {
                return true;
            }
            return false;
        }
        public int UresOszlopokSzama
        {
            get
            {
                int szum = 0;
                for (int i = 0; i < this.T.GetLength(0); i++)
                {
                    if (!this.UresOszlop(i))
                    {
                        szum++;
                    }
                }
                return szum;
            }
        }
        public int UresSorokSzama
        {
            get
            {
                int szum = 0;
                for (int j = 0; j < this.T.GetLength(1); j++)
                {
                    if (!this.UresSor(j))
                    {
                        szum++;
                    }
                }
                return szum;
            }
        }
        public override string ToString()
        {
            string text = "";

            for (int i = 0; i < this.T.GetLength(0); i++)
            {
                for (int j = 0; j < this.T.GetLength(1); j++)
                {
                    text += this.T[i, j] + " ";

                }
                text += "\r\n";
            }
            return text;
        }



    }
}
