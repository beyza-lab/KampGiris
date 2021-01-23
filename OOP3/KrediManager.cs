using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager {//okunurluğu artırmak için ınterface I harfi başlar.

        //imzanın aynı (hesapla) ama içerisisnin farklı oldugu durumlarda
        //classı INTERFACE OLARAK OLUSTURURZ
        //operasyon classı //base class görevi görüyor
        //kredi hesaplarının hepsini burda yaparsak cok karısacak.once kredilerimi class ile oluşturmalıyım.

        void Hesapla();
        void BiseyYap();

        //ınterface kuralları içerir onu implemente eden classlar onu doldurmak zorunda

        //ınterfaceleri birbirlerininn alternatifleri olan ama kod içerikleri farklı olan durumlar için kullanılır
        //tüm kredilerde  hesaplama olacaktır ortaktır, kredinin türlerine göre hesaplama içeriği değişecektir.

       } 
        
    
}
