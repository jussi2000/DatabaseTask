using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Flight
    {
        [Key]
        public Guid Flight_ID { get; set; }
        public string Flight_Nr{ get; set; }
        public DateTime Departure_Date{ get; set; }
        public DateTime Departure_Time{ get; set; }
        public DateTime Arrival_Date { get; set; }
        public DateTime Arrival_Time { get; set; }
        public Guid Passanger_ID { get; set; }

        public ICollection<Gate> Gates { get; set; }
             = new List<Gate>();
        public ICollection<Airline> Airlines { get; set; }
             = new List<Airline>();
        public ICollection<Aircraft> Aircrafts { get; set; }
             = new List<Aircraft>();
        public ICollection<Passanger> Passangers { get; set; }
           = new List<Passanger>();

        public FlightStatus? FlightStatus { get; set; }
    }
}
