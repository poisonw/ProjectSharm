using ProjectSharm.Data.Models;
using ProjectSharm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSharm.Domain.Concrete
{
    public class ProductService : IProduct
    {

        Product GetProductId()
        { }
        IEnumerable<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
