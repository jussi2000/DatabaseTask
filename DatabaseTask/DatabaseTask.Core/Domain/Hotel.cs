using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Hotel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RoomAmount { get; set; }

        public ICollection<Payroll> Payrolls { get; set; }
    = new List<Payroll>();
    }
}
