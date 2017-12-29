using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAngularJS.Models
{
    public class Address
    {
        private string _formattedAddress;

        public string Id { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string Location { get; set; }
        public string State { get; set; }
        public string Postcode { get; set; }
        public string Country { get; set; }

        
        public string FormattedAddress
        {
            get
            {
                //TODO: Handle null/empty better
                return _formattedAddress ?? Line1 + " " + Line2 + " " + Line3 + " " + Line4 + " " + Location + " " + State + " " + Postcode;                
            }
            set
            {
                _formattedAddress = value;
            }

        }
    }
}