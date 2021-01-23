using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//class özlellik ve operasyon tutar.
                 //özellik probla olusturduğumuz.
                 //özellik tuttuğumuz yerde operasyon tutamayız.
    
   //bir veri üzerinde matematik işlmei yapmıyorsan toplama cıkarma gibi
        //metinsel özellik yazılması daha iyi olur string şeklinde tanımlamak
      
    class GercekMusteri:Musteri//bunların içinde operasyonlar olmaz ürün personel çalısan bunlar varlıktır.Bunun için customer manager class actık
    {
        

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
