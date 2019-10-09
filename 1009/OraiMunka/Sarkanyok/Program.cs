namespace Sarkanyok
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat a = new Allat(10, "Karcsi", Allat.Nemek.HIM, Allat.Taplalkozas.NEVENYEVO, "Barna");
            System.Console.WriteLine(a.ToString());

            Sarkany smaug = new Sarkany(300, "Smaug", Allat.Nemek.HIM, "vörös", 1, true);
            System.Console.WriteLine(smaug.ToString());

            SarkanyMagus nicolBolas = new SarkanyMagus(1000,"Nicol Bolas", Allat.Nemek.HIM,"Arany",1,true,143);
            System.Console.WriteLine(nicolBolas.ToString());
        }
    }
}
