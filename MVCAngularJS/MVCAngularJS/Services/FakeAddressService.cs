using System;
using System.Linq;
using System.Collections.Generic;
using MVCAngularJS.Models;

namespace MVCAngularJS.Services
{
    public class FakeAddressService : IAddressService
    {
        private List<Address> _addressList = new List<Address> {
            new Address { Id = 1, Line1 = "1 Short Street", Location = "THE TOWN", State = "NSW", Postcode = "2001" },
            new Address { Id = 2, Line1 = "2 Long Road", Location = "THE CITY", State = "VIC", Postcode = "3001" },
            new Address { Id = 3, Line1 = "Lvl 3, Big Building", Line2 = "3 The Avenue", Location = "SOMEPLACE", State = "NSW", Postcode = "2009" },
            new Address { Id = 4, Line1 = "4 Some Way", Location = "SOMEHOW", State = "NSW", Postcode = "2004" }
        };

        public Address Get(int addressId)
        {
            return _addressList.FirstOrDefault(a => a.Id == addressId);
        }

        public List<Address> Search(string searchTerm)
        {
            return _addressList;
        }
    }
}