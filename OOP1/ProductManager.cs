using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager // ürünle ilgili operasyonlar var içinde ekleme silme güncelleme silme 
                         ////crud (create ,read,updatdelete) veri tabanı operasyonları vardır.a
    {


        //encapsulatıon uzun uzun string ad, ınt 5 yazmak yerıne
        public void Add(Product product) //metodun nasıl çagırılacagını anlattıgımız yer product turunde birsey ver
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update (Product product)
        {
        Console.WriteLine(product.ProductName + "güncellendi.");  }

        //public int Topla(int sayi1 ,int sayi2)
        //{
        //    return sayi1 + sayi2;//sonuc bana başka yerde lazım olacak carpmak ısteyebilirim
           
        //}

        //public void Topla2(int sayi1 ,int sayi2)
        //{
        //    Console.WriteLine(sayi1+sayi2);//void sadece emir kipi topla sonucunda cıkan değeri başka birşekide kullanamam 

        //}




    }
}
