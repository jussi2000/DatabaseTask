using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleAmount { get; set; }
        public Guid EmployeeId { get; set; }
        public string PaymentMethod { get; set; }
        public int RoomAmmount { get; set; }
        public float Cost { get; set; }

        public Guid GuestId { get; set; }

        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();

        public ICollection<Guest> Guests { get; set; }
          = new List<Guest>();
    }
}