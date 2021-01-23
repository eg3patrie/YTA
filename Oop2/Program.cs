using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ege
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.CustomerNum = "12345";
            musteri1.Adi = "Ege";
            musteri1.Soyadi = "Yurt";
            musteri1.TcNo = "98556498";



            //Kodlama io
            GercekMusteri musteri2 = new GercekMusteri();
            musteri2.CustomerNum = "3";
            musteri2.Adi = "Kodlama";
            musteri2.Soyadi = "Io";
            musteri2.TcNo = "88899995555";


            //gercek/tüzel müşteri
            //SOLİD
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add(musteri1);
            customerManager1.Add(musteri2);
            customerManager1.Add(musteri3);
            customerManager1.Add(musteri4);




        }
    }
}
