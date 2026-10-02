using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Room
    {
        [Key]
        public Guid Id { get; set; }
        public string RoomType { get; set; }
        public string Name { get; set; }
        public string Desctription { get; set; }
        public float Price { get; set; }
        public int RoomNr { get; set; }
        public int Floor { get; set; }
        public bool AirCon { get; set; }

        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Booking> Bookings { get; set; }
            = new List<Booking>();
    }
}
