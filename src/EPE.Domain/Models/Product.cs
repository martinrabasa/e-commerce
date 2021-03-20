using System.Collections.Generic;

namespace EPE.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string PrimaryImage { get; set; }
        public ICollection<ProductImage> Images { get; set; }

        public ICollection<Stock> Stock { get; set; }

        public int SubcategoryId { get; set; }
        public Subcategory Subcategory { get; set; }
    }
}