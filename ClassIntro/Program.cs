using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Ehliyet vatandas1 = new Ehliyet();
            vatandas1.adSoyad = "Ege Yurt";
            vatandas1.yas = 16;
            vatandas1.kimlik = "12546875326";

            Ehliyet vatandas2 = new Ehliyet();
            vatandas2.adSoyad = "Ata Yurt";
            vatandas2.yas = 17;
            vatandas2.kimlik = "12546874896";

             Ehliyet vatandas3 = new Ehliyet();
            vatandas3.adSoyad = "Bülent Yurt";
            vatandas3.yas = 46;
            vatandas3.kimlik = "12642875326";

            Ehliyet vatandas4 = new Ehliyet();
            vatandas4.adSoyad = "Nurgül Yurt";
            vatandas4.yas = 45;
            vatandas4.kimlik = "98746875326";

            Ehliyet[] kullanici = new Ehliyet[] {vatandas1 ,vatandas2,vatandas3,vatandas4 };
            foreach (var vatandas in kullanici)
            {
                Console.WriteLine(vatandas.adSoyad+":"+vatandas.yas);
            }


        }
    }

    class Ehliyet
    {
        public string adSoyad { get; set; }
        public int yas { get; set; }
        public string kimlik { get; set; }
    }
}