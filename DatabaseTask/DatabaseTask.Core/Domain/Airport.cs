using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Airport
    {
        [Key]
        public Guid Airport_ID { get; set; }
        public string Flight { get; set; }
        public string Passenger { get; set; }
        public string Aircraft { get; set; }
        public string Gate { get; set; }
        public string Baggage { get; set; }
        public string Airline { get; set; }
    }
}
