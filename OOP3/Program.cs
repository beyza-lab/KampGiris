using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //INTERFACE 
        static void Main(string[] args)
        {
           // İhtiyacKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager();//ınterfacelerde o ınterface ımplemente eden referans değerini tutar.
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileBaseLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService> { new SmsLogService(), new FileBaseLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,loggerServices);
            
            
            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService> { new DataBaseLoggerService(), new SmsLogService() });// kısa yoldan new kodunu böylede yazabiliriz
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);






        }
    }
}
