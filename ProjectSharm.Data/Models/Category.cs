using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectSharm.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
