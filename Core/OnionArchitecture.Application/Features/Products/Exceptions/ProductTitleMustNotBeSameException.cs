﻿using OnionArchitecture.Application.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException:BaseException
    {
        public ProductTitleMustNotBeSameException():base("Ürün başlığı zaten var") {}
    }
}
