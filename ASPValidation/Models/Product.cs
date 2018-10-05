using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPValidation.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [SexAtrribute]
        public string Name { get; set; }

        [Required]
        [Range(0, 10000)]
        public int Price { get; set; }
    }
}
