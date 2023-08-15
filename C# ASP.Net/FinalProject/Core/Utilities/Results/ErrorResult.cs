﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result // Result'ın kendisi
    {
        public ErrorResult(string message) : base(false, message) // base Result demek
        {

        }

        public ErrorResult() : base(false)
        {

        }
    }
   
}
