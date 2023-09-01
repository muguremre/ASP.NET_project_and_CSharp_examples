using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> // AbstractValidator FluentValidation'dan gelir
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty(); // Boş olamaz
            RuleFor(p => p.ProductName).MinimumLength(2); // En az 2 karakter olmalı
            RuleFor(p => p.UnitPrice).NotEmpty(); // Boş olamaz
            RuleFor(p => p.UnitPrice).GreaterThan(0); // 0'dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1); // Kategori id'si 1 olan ürünlerin fiyatı 10'dan büyük veya eşit olmalı
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı"); // Kendi kuralımızı yazdık
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); // A ile başlıyorsa true döner
        }
    }
}
