using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class Sushi
    {   
        [Key]
        public int SushiId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }

        [Required]
        public bool InStock { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public string Allergy { get; set; }

        public bool SushiOfTheDay { get; set; }

    }
}
