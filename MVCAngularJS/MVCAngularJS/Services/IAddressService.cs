using System.Collections.Generic;
using MVCAngularJS.Models;

namespace MVCAngularJS.Services
{
    public interface IAddressService
    {
        Address Get(int addressId);
        List<Address> Search(string searchTerm);
    }
}