using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager=new IhtiyacKrediManager();

            IKrediManager tasitKrediManager =new TasitKrediManager();

            IKrediManager konutKrediManager =new KonutKrediManager();
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();
            ILoggerService smsloggerService = new SmsLoggerService();


            BasvuruManager basvuruManager =new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, databaseloggerService);

            BasvuruManager basvuruManager1 = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, fileloggerService);

            BasvuruManager basvuruManager2 = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseloggerService);
            List <IKrediManager> krediler=new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager, konutKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            BasvuruManager basvuruManager3 = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), smsloggerService);

            Console.WriteLine("--------------------------------------------------");
            Console.ReadKey();

        }
    }
}
