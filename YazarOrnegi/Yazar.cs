using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazarOrnegi
{
    public class Yazar
    {
        public string YazarIsmi { get; set; }

        public string YazarSoyismi { get; set; }

        public void Yaz(string KitapAdi)
        {
            MessageBox.Show($"{KitapAdi} adlı kitap {YazarIsmi} {YazarSoyismi} adlı kişinin eseridir.");

        }
    }
}
