using System;
using System.Collections.Generic;

namespace Interfaces_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<IKrediManager> krediler = new List<IKrediManager> {

            //    new TasitKrediManager(),
            //    new IhtiyacKrediManager(),
            //    new KonutKrediManager()
            
            //};

            List<ILoggerService> loglar = new List<ILoggerService> { 
            
                new DatabaseLoggerService(),
                new FileLoggerService(),
                new SmsLoggerService()
            };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYapVeLogla(new TasitKrediManager(), loglar);


        }
    }

    public interface IKrediManager
    {
        void Hesapla();

    }

    public interface ILoggerService
    {
        void Log();
    }


    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanina Loglandi");
        }
    }

    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandi");
        }
    }

    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms ile gonderilip Loglandi");
        }
    }

    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Hesaplandi");
        }
    }

    class IhtiyacKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac Kredisi Hesaplandi");
        }
    }

    class TasitKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Tasit Kredisi Hesaplandi");
        }
    }

    class BasvuruManager
    {
        public void BasvuruYapVeLogla(IKrediManager kredi,List<ILoggerService> loglar)
        {
            kredi.Hesapla();

            foreach (var log in loglar)
            {
                log.Log();
            }
        }
    }
}
