using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLogService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms loglandı");
        }
    }
}
