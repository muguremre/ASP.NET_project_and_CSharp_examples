using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GercekMusteri gercekMusteri = new GercekMusteri();
           gercekMusteri.Id = 1;
           gercekMusteri.MusteriNo = "12345";
           gercekMusteri.Adi = "Engin";
           gercekMusteri.Soyadi = "Demiroğ";
           gercekMusteri.TcNo = "12345678910";
           TuzelMusteri tuzelMusteri = new TuzelMusteri();
           tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "67890";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234567890";
            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID
            Customer customer1 = new GercekMusteri();
            Customer customer2 = new TuzelMusteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(gercekMusteri);
            customerManager.Add(tuzelMusteri);
            
        }
    }
}
