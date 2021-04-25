using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Maraz Ali";
            int yas = 31;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursunEgitmeni = "Maraz Ali";
            kurs1.İzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "javascript";
            kurs2.KursunEgitmeni = "Ege Yurt";
            kurs2.İzlenmeOrani = 100;
           
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursunEgitmeni = "Ata Yurt";
            kurs3.İzlenmeOrani = 50;

            

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.KursunEgitmeni);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursunEgitmeni { get; set; }
        public int İzlenmeOrani { get; set; }   
    }
}
