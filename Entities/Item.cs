using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Item
    {
        public int ItemId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        public string Category { get; set; }

        [Required]
        [Range(minimum: 0.01, maximum: (double)decimal.MaxValue)]
        public decimal Price { get; set; }




    }
}
