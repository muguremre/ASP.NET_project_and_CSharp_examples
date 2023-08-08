using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string[] names = new string[3];
            //names[0] = "Bob";
            //names[1] = "Steve";
            //names[2] = "Brian";



            //names = new string[4];
            //names[3] = "Robin";
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            List<string> names = new List<string> { "Muhammed", "Uğur", "Emre" };

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            names.Add("İbrahim");
            Console.WriteLine(names[3]);
            Console.WriteLine(names[0]);

            Console.ReadLine();

        }
    }
}
