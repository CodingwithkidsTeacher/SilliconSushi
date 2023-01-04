using Microsoft.AspNetCore.Mvc;
using SilliconSushi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Controllers
{
    public class OrderController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly ApplicationDbContext _db;

        public OrderController(ShoppingCart shoppingCart, ApplicationDbContext db)
        {
            _shoppingCart = shoppingCart;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        // GET
        public IActionResult Checkout()
        {
            var newOrder = new Order();
            return View(newOrder);
        }

        // POST
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetCartItems();

            if (ModelState.IsValid)
            {
                decimal total = 0;

                var orderList = new List<OrderDetails>();

                foreach(var item in items)
                {
                    var itemPrice = item.Amount * item.Sushi.Price;
                    total += itemPrice;

                    var orderDetail = new OrderDetails()
                    {
                        amount = item.Amount,
                        sushi = item.Sushi
                    };

                    orderList.Add(orderDetail);

                    _shoppingCart.RemoveFromShoppingCart(item.Sushi, item.Amount);
                    
                }

                order.orderDetails = orderList;
                order.orderTotal = total;

                // add to db using appContext
                _db.Orders.Add(order);
                _db.SaveChanges();

                //_shoppingCart.shoppingCartItems.Clear();

                return RedirectToAction("OrderComplete");

            }
            return View();
        }

        public IActionResult OrderComplete()
        {
            return View();
        }


    }
}
