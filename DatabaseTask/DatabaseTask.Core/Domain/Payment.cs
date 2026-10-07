using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public float PaymentDate { get; set; }
        public float Ammount { get; set; }
        public string PaymentMethod { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid PlayerId { get; set; }
        public Guid BookingId { get; set; }

        public ICollection<Employee> Employees { get; set; }
             = new List<Employee>();
        public ICollection<Booking> Bookings { get; set; }
              = new List<Booking>();
    }
}