using Microsoft.AspNetCore.Mvc;
using SilliconSushi.Models;
using SilliconSushi.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Controllers
{
    public class ShoppingCartController: Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly ISushiRepository _sushiRepository;

       public ShoppingCartController(ShoppingCart shoppingCart, ISushiRepository sushiRepository)
        {
            _shoppingCart = shoppingCart;
            _sushiRepository = sushiRepository;
        }

        public IActionResult Index()
        {
            var cartViewModel = new CartViewModel();
            cartViewModel.shoppingCartItems = _shoppingCart.GetCartItems();
            cartViewModel.totalPrice = _shoppingCart.GetTotalPrice();

            return View(cartViewModel);
        }

        public RedirectToActionResult AddToCart(int sushiId)
        {
            var selectedSushi = _sushiRepository.AllSushi.FirstOrDefault(s => s.SushiId == sushiId);

            if( selectedSushi != null)
            {
                _shoppingCart.AddToShoppingCart(selectedSushi, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int sushiId)
        {
            var selectedSushi = _sushiRepository.AllSushi.FirstOrDefault(s => s.SushiId == sushiId);

            if (selectedSushi != null)
            {
                _shoppingCart.RemoveFromShoppingCart(selectedSushi, 1);
            }

            return RedirectToAction("Index");
        }


    }
}
