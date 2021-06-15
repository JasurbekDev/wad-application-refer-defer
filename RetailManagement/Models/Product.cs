using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RetailManagement.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string Brand { get; set; }

        [Required]
        [Range(typeof(decimal), "0", "999999999.99")]
        public decimal Price { get; set; }

        [StringLength(500, MinimumLength = 5)]
        public string Description { get; set; }

        [MaxLength]
        public byte[] Image { get; set; }

        public int? ProductLeft { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
