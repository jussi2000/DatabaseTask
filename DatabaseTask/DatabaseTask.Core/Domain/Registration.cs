using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Registration
    {
        [Key]
        public Guid Registration_ID { get; set; }
        public DateTime Registration_Date { get; set; }
        public string Ticket_Type { get; set; }

        public ICollection<Passanger> Passangers { get; set; }
              = new List<Passanger>();
    }
}
