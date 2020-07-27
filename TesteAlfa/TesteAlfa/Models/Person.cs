namespace TesteAlfa.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string UserName { get; set; }

        public string[] Emails => new[] { "lewisblack@example.com" };

        public AddressInfo[] AddressInfo => new[] { new AddressInfo() };
    }

    public class AddressInfo
    {
        public string Address => "187 Suffolk Ln.";
        public City City => new City();
    }

    public class City
    {
        public string Name => "Boise";
        public string CountryRegion { get; set; }
        public string Region => "ID";
    }
}
