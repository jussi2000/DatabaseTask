using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Bookable
    {
        [Key]
        public Guid Id { get; set; }
        public string ExtraInfo { get; set; }
        public string Status { get; set; }
        public Guid BookingId { get; set; }
        public Guid RoomId { get; set; }

        public ICollection<Room> Rooms { get; set; }
             = new List<Room>();
        public ICollection<Booking> Bookings { get; set; }
            = new List<Booking>();
    }
}
