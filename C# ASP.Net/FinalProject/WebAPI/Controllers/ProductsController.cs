using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //Attribute
    public class ProductsController : ControllerBase
    {
        IProductService _productService; // Global değişkenler _ ile başlar

        // Loosely coupled -- gevşek bağlılık
        //injection
        // IoC Container -- Inversion of Control -- Değişimin kontrolü
        public ProductsController(IProductService productService)
        { 
           _productService = productService;

        }
        [HttpGet]
        public List<Product> Get()
        {
            // Dependency chain -- bağımlılık zinciri
             // EfProductDal'ı new'ledik
            var result = _productService.GetAll(); // GetAll'ı çağırdık
           return result.Data; // Data'yı döndürdük
        }
        //public string Get()
        //{
        //   var result = new ProductManager(new EfProductDal()).GetAll();

        //    return result.Message;
        //}
    }
}
