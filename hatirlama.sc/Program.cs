using System;

namespace hatirlama.sc
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 50;
            Console.WriteLine(yas);
            string adi = "Ege";
            Console.WriteLine(adi);
            double dolarTL = 8.23;
            Console.WriteLine(dolarTL);
            bool giris = (false);

            if (giris == false)
            {
                Console.WriteLine("Giriş Butonu");
            }
            else if (giris==true)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            Console.WriteLine("-------------------------");

            string[] kullanici = new string[] {"Ege","Ata","Bülent","Nurgül" };

            for (int i = 0; i < kullanici.Length; i++)
            {
                Console.WriteLine(kullanici[i]);
            }
            Console.WriteLine("----------------");

            foreach (string kullanmak in kullanici)
            {
                Console.WriteLine(kullanmak);

            }



        }
    }
}
