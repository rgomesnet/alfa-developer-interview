using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAlfa.Models
{
    public class AirportService
    {
        private readonly RestClient client;

        public AirportService()
        {
            this.client = new RestClient("https://services.odata.org/TripPinRESTierService");
        }

        public IEnumerable<Airport> List()
        {
            var response = client.Execute<ODataCollectionWrapper<Airport>>(new RestRequest("Airports", Method.GET));
            return response.Data.Value;
        }
    }
}