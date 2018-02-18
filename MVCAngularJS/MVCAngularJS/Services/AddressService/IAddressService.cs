using System.Collections.Generic;
using MVCAngularJS.Models;

namespace MVCAngularJS.Services.AddressService
{
    public interface IAddressService
    {
        Address Get(int addressId);
        Address GetByPlaceId(string placeId);
        List<Address> Search(string searchTerm);
    }
}