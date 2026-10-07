using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PersonalId { get; set; }
        public Guid HotelId { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
            = new List<Hotel>();
    }
}