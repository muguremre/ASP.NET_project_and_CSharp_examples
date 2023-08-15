using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); // Tüm ürünleri listeleyecek
        IDataResult <List<Product>> GettAllByCategoryId(int id);// Kategoriye göre ürünleri listeleyecek

        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max); // Fiyat aralığına göre ürünleri listeleyecek
        IDataResult <List<ProductDetailDto>> GetProductDetails(); // Ürün detaylarını listeleyecek
        IResult Add(Product product); // Ürün ekleme
        IDataResult <Product> GetById(int productId); 
    }
}   
