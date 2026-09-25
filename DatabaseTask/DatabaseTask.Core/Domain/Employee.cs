using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        public int? Costumer_ID { get; set; }
        public Costumer? Costumer { get; set; }

        public int? Child_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string First_name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Last_name { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Contact_e_mail { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Contact_phone_number { get; set; } = string.Empty;

        public ICollection<Child> Children { get; set; } = new List<Child>();
        public ICollection<HealthCare> HealthCares { get; set; } = new List<HealthCare>();
        public ICollection<Borrows> Borrows { get; set; } = new List<Borrows>();
        public ICollection<Company> Companies { get; set; } = new List<Company>();
        public ICollection<Intranet> Intranets { get; set; } = new List<Intranet>();
        public ICollection<Rank> Ranks { get; set; } = new List<Rank>();
        public ICollection<Service> Services { get; set; } = new List<Service>();
    }
}