using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Basvuran bilgilerini degerlendirme

            if(krediManager is KonutKrediManager)
            {
                KonutKrediManager konutKrediManager = new KonutKrediManager();
                konutKrediManager.Hesapla();

            }
            else if(krediManager is TasitKrediManager)
            {
                TasitKrediManager tasitKrediManager = new TasitKrediManager();
                tasitKrediManager.Hesapla();


            }
            else if(krediManager is IhtiyacKrediManager)
            {
                IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
                ihtiyacKrediManager.Hesapla();


            }
            else if (krediManager is EsnafKredisiManager)
            {
                EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();
                esnafKredisiManager.Hesapla();
            }

            else
            {
                Console.WriteLine("Bilinmeyen kredi türü");
            }
            loggerService.Log();

    
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }
    }
}
