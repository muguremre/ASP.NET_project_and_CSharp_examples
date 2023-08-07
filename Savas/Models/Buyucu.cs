using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savas.Models
{
    public class Buyucu
    {
        public string OyuncuIsmi { get; set; }
        public string Silah { get; set; }
        public string Brans { get; set; }
        public string Irk { get; set; }

        public int SaldırıGucu { get; set; }

        public void Saldir()
        {
            switch (Brans)
            {
                case "KaraBüyü":
                    SaldırıGucu = 50;
                    break;

                case "Defansif":
                    SaldırıGucu = 10;
                    break;

                default:
                    SaldırıGucu = 30;
                    break;

            }
        }
    }
}
