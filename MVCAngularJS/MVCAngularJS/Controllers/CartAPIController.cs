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
        [HttpGet, Route("{id}")]
        public Cart Get(int id) => new Cart();
               
        [HttpPost, Route("")]
        public int Post(Cart cart)
        {

            // todo save cart somewhere

            return 1;
        }
    }
}
