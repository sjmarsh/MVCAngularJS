using MVCAngularJS.Models;
using MVCAngularJS.Services.AddressService;
using System.Collections.Generic;
using System.Web.Http;

namespace MVCAngularJS.Controllers
{
    [RoutePrefix("api/address")]
    public class AddressAPIController : ApiController
    {
        private IAddressService _addressService;

        public AddressAPIController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [Route("{id}")]
        public Address Get(string id)
        {
            return _addressService.Get(id);
        }

        [HttpGet()]
        [Route("search/{searchTerm}")]
        public List<Address> Search(string searchTerm)
        {
            return _addressService.Search(searchTerm);            
        }
    }
        
}
