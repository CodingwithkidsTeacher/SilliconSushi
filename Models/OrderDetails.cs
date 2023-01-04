using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class OrderDetails
    {
        public int OrderDetailsId { get; set; }
        public Sushi sushi { get; set; }
        public int amount { get; set; }
    }
}
