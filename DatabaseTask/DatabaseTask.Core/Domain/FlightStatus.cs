using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class FlightStatus
    {
        [Key]
        public Guid FlightStatus_ID { get; set; }
        public string Flight_status_change { get; set; }
        public DateTime Time_change { get; set; }
        public string reason { get; set; }
    }
}
