using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class ServiceOrder
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ServiceId { get; set; }
        public Guid BookingId { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Booking> Bookings { get; set; }
             = new List<Booking>();
        public ICollection<Service> Services { get; set; }
            = new List<Service>();

    }
}
