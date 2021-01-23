using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin ";
            int yas = 36;

            Kurs  kurs1 = new Kurs();
            kurs1.kursAdi = "Java";
            kurs1.Egitmen = "Kerem Varış";
            kurs1.IzlenmeOrani = 64;

            Kurs kurs2= new Kurs();
            kurs2.kursAdi = "c#";
            kurs2.Egitmen = "Engin Demiroğ";
            kurs2.IzlenmeOrani = 68;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.kursAdi + ":" + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (Kurs  kurs in kurslar)
            {
                Console.WriteLine(kurs1.kursAdi + ":" + kurs1.Egitmen;
            }

            
            
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
