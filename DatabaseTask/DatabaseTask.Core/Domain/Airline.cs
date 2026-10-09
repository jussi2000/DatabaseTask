using System.ComponentModel.DataAnnotations;
namespace DatabaseTask.Core.Domain
{
    public class Airline
    {
        [Key]
        public Guid Airline_ID { get; set; }
        public string Country { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

        public ICollection<Airport> Airports { get; set; }
            = new List<Airport>();
    }
}
