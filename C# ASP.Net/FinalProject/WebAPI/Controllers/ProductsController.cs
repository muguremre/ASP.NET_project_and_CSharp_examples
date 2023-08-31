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
        [HttpGet("getall")]
        public IActionResult Get()
        {
            // Dependency chain -- bağımlılık zinciri
            // EfProductDal'ı new'ledik
            var result = _productService.GetAll(); // GetAll'ı çağırdık

            if (result.Success)
            {
                return Ok(result); // 200
            }
            return BadRequest(result); // 400


            // Data'yı döndürdük
        }
        //public string Get()
        //{
        //   var result = new ProductManager(new EfProductDal()).GetAll();

        //    return result.Message;
        //}

        [HttpPost("add")]
        public IActionResult Post(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
