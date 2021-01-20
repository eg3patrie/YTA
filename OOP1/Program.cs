using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product();
            product2.Id = 5;
            product2.CategoryId = 22;
            product2.ProductName = "Kalem";
            product2.UnitPrice = 50;
            product2.UnitsInStock = 10;

            //PascalCase //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            int sayi = 100;
            productManager.Test(sayi);
            Console.WriteLine(sayi);

            //int ,double,bool... değer tip
            //diziler ,class... referans tip

        }
    }
}
