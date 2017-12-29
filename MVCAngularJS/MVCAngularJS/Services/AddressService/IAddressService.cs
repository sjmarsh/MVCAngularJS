using System.Collections.Generic;
using MVCAngularJS.Models;

namespace MVCAngularJS.Services.AddressService
{
    public interface IAddressService
    {
        Address Get(string addressId);
        List<Address> Search(string searchTerm);
    }
}