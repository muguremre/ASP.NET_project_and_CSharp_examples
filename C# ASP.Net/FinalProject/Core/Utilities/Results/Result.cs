using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        // Constructor'lar bir class new'lendiğinde çalışan bloklardır.
        // get sadece okunabilir demek
        // this demek class'ın kendisi demek
        // this(success, message) demek 2 parametreli olanı da çalıştır demek

        public Result(bool success, string message):this(success) // this(success) demek tek parametreli olanı da çalıştır demek
        {
            Message = message;
        }
        // Overloading
        // Overloading aynı isimde metotların farklı parametrelerle çalışmasıdır.
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
