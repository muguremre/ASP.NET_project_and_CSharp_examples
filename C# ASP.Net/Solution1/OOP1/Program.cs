using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product {Id = 1, CategoryId = 1,
                ProductName = "Kalem", UnitsInStock = 5000, UnitPrice = 100 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

        }
    }
}
