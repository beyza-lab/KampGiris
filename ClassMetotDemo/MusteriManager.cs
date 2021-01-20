using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) //İşlem tanımlandı (işlemin uygulanacağı parametre)
        {
            Console.WriteLine("Tebrikler!  Müsteri listeye  eklendi. : " + musteri.Adi+" "+ musteri.Soyadi+" "+ " "+musteri.Id); //Tanımlanan işlem yürütüldü.
        }

        public void Sil(Musteri musteri) //İşlem tanımlandı (işlemin uygulanacağı parametre)
        {
            Console.WriteLine("Tebrikler! Müsteri Silindi. : " + musteri.Adi+" " + musteri.Soyadi+" "+ " "+musteri.Id); //Tanımlanan işlem yürütüldü.
        }
        public void listele(Musteri musteri) //İşlem tanımlandı (işlemin uygulanacağı parametre)
        {
            Console.WriteLine("Tebrikler! Müsteri Listelendi. : " + musteri.Adi+" " + musteri.Soyadi +" "+" "+ musteri.Id); //Tanımlanan işlem yürütüldü.
        }


    }


}
