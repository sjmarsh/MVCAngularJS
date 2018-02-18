using MVCAngularJS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCAngularJS.Data
{
    public class CartContext : DbContext
    {
        public DbSet<Cart> Carts { get; set; }

    }
}