using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public float PaymentDate { get; set; }
        public float PaymentAmmount { get; set; }
        public string PaymentMethod { get; set; }

        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }

    }
}