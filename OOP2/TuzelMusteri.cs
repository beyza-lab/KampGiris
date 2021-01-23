using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{     //class özlellik ve operasyon tutar.
      //özellik probla olusturduğumuz.
      //özellik tuttuğumuz yerde operasyon tutamayız.

    //bir veri üzerinde matematik işlmei yapmıyorsan toplama cıkarma gibi
    //metinsel özellik yazılması daha iyi olur string şeklinde tanımlamak
    //bunların içinde operasyonlar olmaz ürün personel çalısan bunlar varlıktır.
    class TuzelMusteri : Musteri //MÜŞTERİDE OLAN HERŞEY TÜZELDE DE KABUL EDİLİR
                                 //tuzel müşteri bir müşteridir.BUNA INHERITANCE MİRAS DİYORUZ.

    
    {

        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
