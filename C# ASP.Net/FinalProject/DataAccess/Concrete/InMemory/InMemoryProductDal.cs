using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // Global değişkenler _ ile başlar
        public InMemoryProductDal()
        {
            // Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // Linq kullanarak silme işlemi

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            // Tek bir eleman bulmaya yarar. foreach gibi döner. Her p için p nin ProductId si benim gönderdiğim product ın ProductId sine eşit mi diye bakar. Eşitse onu productToDelete ye atar.
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products; // Veritabanını olduğu gibi döndürüyoruz
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName; // Güncelleme işlemini yapıyoruz
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;



        }


        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
            // Where koşulu içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve onu döndürür.
        }

    }
}
