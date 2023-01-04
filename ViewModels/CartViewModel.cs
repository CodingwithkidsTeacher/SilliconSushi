using SilliconSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.ViewModels
{
    public class CartViewModel
    {
        public List<ShoppingCartItem> shoppingCartItems { get; set; }
        public decimal totalPrice { get; set; }
    }
}
