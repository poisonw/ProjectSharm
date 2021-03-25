using ProjectSharm.Data.Models;
using ProjectSharm.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSharm.Domain.Concrete
{
    public class ProductService : IProduct
    {
        public IEnumerable<Product> GetAllProduct()
        {
            throw new NotImplementedException();
        }

        public Product GetProductId()
        {
            throw new NotImplementedException();
        }
    }
}
