using ProjectSharm.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSharm.Domain.Interfaces
{
    public interface IProduct
    {
        Product GetProductId { get; set; }
        IEnumerable<Product> GetAllProduct();

    }
}
