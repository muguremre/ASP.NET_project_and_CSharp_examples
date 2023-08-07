using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        public Bebek()
        {
            BirthDate = DateTime.Now;

        }
        public Bebek(string name)
        {
            Name = name;
            BirthDate = DateTime.Now;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
     

    }
}
