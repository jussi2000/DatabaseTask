using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Aircraft
    {
        [Key]
        public Guid Aircraft_ID { get; set; }
        public string Registration_Nr { get; set; }
        public string Model { get; set; }
        public string Seat_Amount { get; set; }
        public string Year_Of_Manufaceture { get; set; }

    }
}
