using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Passanger
    {
        [Key]
        public Guid Passanger_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Identification_Nr { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public Guid Registration_ID { get; set; }
    }
}
