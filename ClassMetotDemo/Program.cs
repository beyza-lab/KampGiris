using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.Id = 234567;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "ipek";
            musteri2.Soyadi = "acar";
            musteri2.Id = 345123;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "elif";
            musteri3.Soyadi = "orak";
            musteri3.Id = 12345;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 ,musteri3};
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
            }
                
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);//ekleme düğmesinin olması istenen yere konur.
            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri1);
            musteriManager.listele(musteri3);
            musteriManager.listele(musteri2);
        }
    }
}
