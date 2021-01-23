using System;

namespace OOP2//object oriented project nesne yönelimli programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.TcNo = "3456777";
            musteri1.Id = 3;

            //kodloma.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 1;
            musteri2.SirketAdi = "kodloma.io";
            musteri2.VergiNo = "23455";
            musteri2.MusteriNo = "45567";


            //gerçek-Tüzel iki nesne ikiside farklı müşteritipleri 
            //birbirinin yerine kullanılamaz
            //SOLİD YAZILIM TEKNİKLERİ BİRBİRİNİN YERİNE KULLANMA
            //ınheritance olduğu için musteri classı hem gercek hem tuzel kişinin referansını tutuyor tutuyor
            
            
            Musteri musteri3 = new GercekMusteri(); //new görürsen o referans classı
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);








        }
    }
}
