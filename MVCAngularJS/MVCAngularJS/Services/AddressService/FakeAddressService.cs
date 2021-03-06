﻿using System;
using System.Linq;
using System.Collections.Generic;
using MVCAngularJS.Models;

namespace MVCAngularJS.Services.AddressService
{
    public class FakeAddressService : IAddressService
    {
        private List<Address> _addressList = new List<Address> {
            new Address { PlaceId = "0001", AddressLine1 = "1 Short Street", Location = "THE TOWN", State = "NSW", Postcode = "2001" },
            new Address { PlaceId = "0002", AddressLine1 = "2 Long Road", Location = "THE CITY", State = "VIC", Postcode = "3001" },
            new Address { PlaceId = "0003", AddressLine1 = "Lvl 3, Big Building", AddressLine2 = "3 The Avenue", Location = "SOMEPLACE", State = "NSW", Postcode = "2009" },
            new Address { PlaceId = "0004", AddressLine1 = "4 Some Way", Location = "SOMEHOW", State = "NSW", Postcode = "2004" }
        };

        public Address Get(int id)
        {
            return new Address();
        }

        public Address GetByPlaceId(string addressId)
        {
            return _addressList.FirstOrDefault(a => a.PlaceId == addressId);
        }

        public List<Address> Search(string searchTerm)
        {
            return _addressList;
        }
    }
}