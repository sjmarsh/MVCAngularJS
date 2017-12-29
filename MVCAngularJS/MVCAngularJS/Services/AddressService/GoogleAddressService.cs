using System;
using System.Linq;
using System.Collections.Generic;
using MVCAngularJS.Models;
using System.Net.Http;

namespace MVCAngularJS.Services.AddressService
{
    public class GoogleAddressService : IAddressService
    {
        private const string BaseUrl = "https://maps.googleapis.com/maps/api/geocode/";

        public Address Get(string addressId)
        {
            var key = ""; // TODO add to config
            
            var query = "json?key=" + key + "&place_id=" + addressId;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                HttpResponseMessage response = client.GetAsync(query).Result;
                response.EnsureSuccessStatusCode();
                var googleResult = response.Content.ReadAsAsync<GoogleGeocodeResponse>().Result;
            }

            return new Address(); // do this for now. need to use api key to get address from google
        }

        public List<Address> Search(string searchTerm)
        {
            //TODO make async
            var result = new List<Address>();

            try
            {
                if (searchTerm.Length > 2)
                {
                    var query = "json?address=" + searchTerm + "&region=au";

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(BaseUrl);
                        HttpResponseMessage response = client.GetAsync(query).Result;
                        response.EnsureSuccessStatusCode();
                        var googleResult = response.Content.ReadAsAsync<GoogleGeocodeResponse>().Result;

                        result = ConvertGoogleResult(googleResult.results);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured retrieving address from google.", ex);
            }
                        
            return result;
        }

        private List<Address> ConvertGoogleResult(List<GeocodeResult> geocodeResults)
        {
            var result = new List<Address>();

            if(geocodeResults != null && geocodeResults.Any())
            {
                foreach (var geocodeResult in geocodeResults)
                {
                    result.Add(ConvertGoogleAddress(geocodeResult));
                }
            }

            return result;
        }

        private Address ConvertGoogleAddress(GeocodeResult geocodeResult)
        {
            var address = new Address();
                        
            address.Id = geocodeResult.place_id;

            // very basic mapping TODO: handle more complex address types
            var streetNum = GetAddressComponent(geocodeResult, "street_number");
            var streetName = GetAddressComponent(geocodeResult, "route");
            address.Line1 = streetNum + " " + streetName;
            address.Location = GetAddressComponent(geocodeResult, "locality");
            address.State = GetAddressComponent(geocodeResult, "administrative_area_level_1");
            address.Postcode = GetAddressComponent(geocodeResult, "postal_code");

            address.FormattedAddress = geocodeResult.formatted_address;

            return address;
        }

        private static string GetAddressComponent(GeocodeResult result, string componentType)
        {
            return result.address_components.FirstOrDefault(c => c.types.Contains(componentType))?.short_name;
        }
    }
}