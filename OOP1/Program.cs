using System;

namespace OOP1//nesne yönelimli proje 
{
    class Program
    {
        static void Main(string[] args)
        {
            Product  product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //ayrı ayrı vermeden üstteki gibi bu sekildede yazabiliriz
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock=5, ProductName="kalem", UnitPrice=35 };

            //classları PascalCase //camelCase
            //case senstive kucuk buyuk ad duyarlı
            
            ProductManager productManager = new ProductManager();
            //string isim = "engin";  gibi
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //productManager.Topla2(3, 6);//void ile
            //int toplamasonucu = productManager.Topla(3, 6);
            //Console.WriteLine(toplamasonucu * 2);
        }
    }
}
