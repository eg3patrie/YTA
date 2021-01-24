using System;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 musteri1 = new Class1();
            musteri1.Adi = "Ege";
            musteri1.Soyadi = "Yurt";
            musteri1.Id = 3;
            musteri1.Sehri = "Bursa";

            Console.WriteLine(musteri1.Adi +" " + musteri1.Soyadi + ":"  + musteri1.Sehri);

        }
    }
}
