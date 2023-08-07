using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol.Models
{
    internal class Futbolcu
    {
        public Futbolcu(string _isim, string _ulke)
        {
            Isim = _isim;
            Ulke = _ulke;
            switch(Ulke)
            {
                case "Brezilya":
                    SutGucu = 90;
                    break;
                case "İngiltere":
                    SutGucu = 80;
                    break;
                case "İspanya":
                    SutGucu = 70;
                    break;
                default:
                    SutGucu = 50;
                    break;
            }
        }
        public string Isim { get; set; }
        public string Ulke { get; set; }
        public int Moral { get; set; }
        public int SutGucu { get; set; }
      
    }
}
