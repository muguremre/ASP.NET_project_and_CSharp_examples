using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
              
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + product.Adi);


        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {

            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urunAdi);

        }
    }
}
