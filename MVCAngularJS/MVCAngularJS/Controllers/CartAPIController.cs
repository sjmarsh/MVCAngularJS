using MVCAngularJS.Data;
using MVCAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAngularJS.Controllers
{
    [RoutePrefix("api/cart")]
    public class CartAPIController : ApiController
    {
        private CartContext _cartDbContext;

        public CartAPIController(CartContext cartContext)
        {
            _cartDbContext = cartContext;
        }

        [HttpGet, Route("{id}")]
        public Cart Get(int id) => new Cart();
               
        [HttpPost, Route("")]
        public int Post(Cart cart)
        {
            // todo some more validation and error handling would be nice!
            if(cart != null)
            {
                _cartDbContext.Carts.Add(cart);
                _cartDbContext.SaveChanges();
            }
            
            return cart.Id;
        }
    }
}
