using System;
using System.Collections.Generic;

#nullable disable

namespace API.CQRS.Sample.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
    }
}
