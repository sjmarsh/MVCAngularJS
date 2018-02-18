using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAngularJS.Models
{
    public class Address
    {
        private string _formattedAddress;

        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }

        public string PlaceId { get; set; }

        public string FormattedAddress
        {
            get
            {
                //TODO: Handle null/empty better
                return _formattedAddress ?? AddressLine1 + " " + AddressLine2 + " " + AddressLine3 + " " + AddressLine4 + " " + Location + " " + State + " " + Postcode;                
            }
            set
            {
                _formattedAddress = value;
            }

        }
                
    }
}