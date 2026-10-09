using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Gate
    {
        [Key]
        public Guid Gate_ID { get; set; }
        public string Gate_Nr { get; set; }
        public string max_aircraft_size { get; set; }
        public string min_aircraft_size { get; set; }
        public Guid Flight_ID { get; set; }
        public ICollection<Terminal> Terminals { get; set; }
             = new List<Terminal>();
    }
}
