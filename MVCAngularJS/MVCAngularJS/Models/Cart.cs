using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAngularJS.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public PersonDetails PersonalDetails { get; set; }
        public Address AddressDetails { get; set; }


    }
}