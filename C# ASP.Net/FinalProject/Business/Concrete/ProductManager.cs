using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService // IProductService implemente edilir
    {
        IProductDal _productDal; // Global değişkenler _ ile başlar

        // Bir iş sınıfı başka sınıfları new'lemez.
        // Constructor injection
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult <List<Product>> GetAll()
        {
            if(DateTime.Now.Hour==22)
            {
                // Mesaj, başarılı mı, data
                // MaintenanceTime: Bakım zamanı
                // ErrorDataResult: Hata mesajı ve data döndürür
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            // İş kodları
            // Yetkisi var mı?
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);

        }

        public IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult <List<Product>>(_productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult <List<Product>> GettAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>> (_productDal.GetAll(p => p.CategoryId == id));

        }

        public IDataResult <List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        [ValidationAspect(typeof(ProductValidator))] // ProductValidator'ı doğrula
        public IResult Add(Product product)
        {
           
            // İş kodları 

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult <Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

    }
}
