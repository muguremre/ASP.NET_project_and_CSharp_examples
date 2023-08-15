using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(); // Tüm ürünleri listeleyecek
        List<Product> GettAllByCategoryId(int id);// Kategoriye göre ürünleri listeleyecek

        List<Product> GetByUnitPrice(decimal min, decimal max); // Fiyat aralığına göre ürünleri listeleyecek
        List<ProductDetailDto> GetProductDetails(); // Ürün detaylarını listeleyecek
    }
}   
