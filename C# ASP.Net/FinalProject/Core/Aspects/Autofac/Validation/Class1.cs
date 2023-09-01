using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.İnterceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception // MethodInterception: OnBefore, OnAfter, OnException, OnSuccess
    {
        private Type _validatorType; // ProductValidator
        public ValidationAspect(Type validatorType) // ProductValidator
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType)) // gelen validatorType bir IValidator değilse
            {
                throw new System.Exception("Bu bir doğrulama sınıfı değil."); // throw new Exception: hata fırlat
            }

            _validatorType = validatorType; // ProductValidator
        }
        protected override void OnBefore(IInvocation invocation) // invocation: method demek
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType); // reflection
            var entityType = _validatorType.BaseType.GetGenericArguments()[0]; // ProductValidator'ın base type'ını bul ve onun generic argümanlarını bul. (Product)
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType); // invocation'ın argümanlarını gez ve entityType'a eşit olanları bul. (Product)
            foreach (var entity in entities) // bulduğun her bir entity için doğrula
            {
                ValidationTool.Validate(validator, entity); // ValidationTool'u kullanarak doğrula
            }
        }
    }
}
