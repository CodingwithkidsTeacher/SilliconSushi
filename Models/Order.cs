using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required (ErrorMessage = "Please enter your first name!")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        [Display(Name= "Last Name")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Please enter your address!")]
        [Display(Name = "Address")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter your zip code!")]
        [Display(Name = "Zip Code")]
        public int zipCode { get; set; }

        public List<OrderDetails> orderDetails { get; set; }

        public decimal orderTotal { get; set; }
    }
}
