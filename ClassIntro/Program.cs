using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Programlamaya giriş";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOran = 20000;

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOran { get; set; }
    }
}
