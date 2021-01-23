using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // ()hangi kredi olacagını, hangı log olacagını enjekte ediyoruz.Method ınjection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)//konut tasıt ıhtıyac kredisini yollayabilirim//birden fazla log o yuzden liste
        {
            //Başvuran bilgilerini değerlendirme


            krediManager.Hesapla();
            //loggerService.Log();//sistemde hangi loglayıcı seçilmişşe onu logla


            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }//birden fazla logger kullanmak ıstıyorsam
            
               
            
        }

    
        
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler )//birden fazla kredi türünü hesaplamak istiyorum
        {
            foreach (var kredi in krediler)//listedeki herbir kredinin hesaplamasını yap
            {
                kredi.Hesapla();
                    
            }



        }












    }   
    
    
}
