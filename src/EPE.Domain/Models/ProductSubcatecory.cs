using System.Collections.Generic;

namespace EPE.Domain.Models
{
    public class ProductSubcategory
    {
        public int Id { get; set; }   
        public string Name { get; set; }

        public int CategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}