﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Image { get; set; }

        public ICollection<Stock> Stock { get; set; }

    }
}
