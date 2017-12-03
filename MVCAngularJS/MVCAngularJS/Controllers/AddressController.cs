using MVCAngularJS.Models;
using MVCAngularJS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAngularJS.Controllers
{
    [RoutePrefix("api/address")]
    public class AddressController : ApiController
    {
        private IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [Route("{id:int}")]
        public Address Get(int id)
        {
            return _addressService.Get(id);
        }

        [HttpGet()]
        [Route("{searchTerm}")]
        public List<Address> Search(string searchTerm)
        {
            return _addressService.Search(searchTerm);            
        }
    }
        
}
