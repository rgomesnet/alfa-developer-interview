namespace TesteAlfa.Models
{
    public class Airport
    {
        public string Name { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public string Address { get; set; }
        public City City { get; set; }
    }   
}
