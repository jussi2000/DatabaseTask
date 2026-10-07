using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleCount { get; set; }
        public string PaymentMethod { get; set; }
        public int RoomAmmount { get; set; }
        public float Cost { get; set; }

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();
        public ICollection<ServiceOrder> ServiceOrders { get; set; }
            = new List<ServiceOrder>();
        public ICollection<Bookable> Bookable { get; set; }
                = new List<Bookable>();
    }
}