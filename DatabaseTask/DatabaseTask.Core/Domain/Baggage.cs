using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Baggage
    {
        [Key]
        public Guid Baggage_ID { get; set; }
        public string Baggage_Tag_Nr { get; set; }
        public string Weight { get; set; }
        public string Baggage_Type { get; set; }

        public ICollection<Passanger> Passangers { get; set; }
            = new List<Passanger>();
    }
}
