using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilliconSushi.Models
{
    public class ShoppingCart
    {
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> shoppingCartItems { get; set; }

        private readonly ApplicationDbContext _db;

        public ShoppingCart(ApplicationDbContext db)
        {
            _db = db;
        }
        /*
        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            var context = services.GetService<ApplicationDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }
        */
        public void AddToShoppingCart(Sushi sushi, int amount)
        {
            // check if item is already in the cart
            var checkItem = _db.ShoppingCartItems.SingleOrDefault(i => i.Sushi.SushiId == sushi.SushiId);

            if (checkItem == null)  // we don't find it
            {
                //Create to the shoppingCart
                checkItem = new ShoppingCartItem
                {
                    //ShoppingCartItemId = checkItem.ShoppingCartItemId,
                    Sushi = sushi,
                    Amount = amount
                };
                // Save in the database --apDeb save changes
                _db.ShoppingCartItems.Add(checkItem);
            }
            else
            {
                //increase item amount in the shopping cart
                checkItem.Amount += amount;
            }

            _db.SaveChanges();

        }

        public void RemoveFromShoppingCart(Sushi sushi, int amount)
        {
            // check if item is already in the cart
            var checkItem = _db.ShoppingCartItems.SingleOrDefault(i => i.Sushi.SushiId == sushi.SushiId);

            if (checkItem != null) 
            {
                var localAmount = checkItem.Amount - amount;

                if (localAmount > 0)
                {
                    //increase item amount in the shopping cart
                    checkItem.Amount = localAmount;
                }
                else
                {
                    //remove from database
                    _db.ShoppingCartItems.Remove(checkItem);
                }
                
            }

            _db.SaveChanges();

        }
        /*
        public void RemoveAllFromShoppingCart(Sushi sushi)
        {
            // check if item is already in the cart
            var checkItem = _db.ShoppingCartItems.SingleOrDefault(i => i.Sushi.SushiId == sushi.SushiId);

            if (checkItem != null)
            {
            
                    //remove from database
                    _db.ShoppingCartItems.Remove(checkItem);
                

            }

            _db.SaveChanges();

        }*/

        public decimal GetTotalPrice()
        {
            var totalList = _db.ShoppingCartItems.Select(i => i.Sushi.Price * i.Amount).ToList();
            
            decimal total = 0;
            foreach (var item in totalList)
            {
                total += item;
            }
            
            return total;
        }

        public List<ShoppingCartItem> GetCartItems()
        {
            var items = _db.ShoppingCartItems.Include(s => s.Sushi).ToList();

            return items;
        }
    }
}
