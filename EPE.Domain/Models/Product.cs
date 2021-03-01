using System.Collections.Generic;

namespace EPE.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string Image { get; set; }

        public ICollection<Stock> Stock { get; set; }
    }
}