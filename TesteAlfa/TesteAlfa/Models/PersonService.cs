using RestSharp;
using System.Collections.Generic;
using System.Text.Json;

namespace TesteAlfa.Models
{
    public class PersonService
    {
        private readonly RestClient client;

        public PersonService()
        {
            this.client = new RestClient("https://services.odata.org/TripPinRESTierService");
        }

        public IEnumerable<Person> List()
        {
            var response = client.Execute<ODataCollectionWrapper<Person>>(new RestRequest("People", Method.GET));
            return response.Data.Value;
        }

        public void Create(Person person)
        {
            var request = new RestRequest("People", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };
            var jsonString = JsonSerializer.Serialize(person);
            request.AddParameter("application/json; charset=utf-8", jsonString, ParameterType.RequestBody);
            request.AddHeader("Accept", "application/json;odata=verbose");
            IRestResponse response = client.Execute(request);
        }
    }
}
