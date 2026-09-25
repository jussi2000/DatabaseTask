using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Service
    {
        [Key]
        public int Service_ID { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; } = string.Empty;

        public ICollection<Company> Companies { get; set; } = new List<Company>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Costumer> Costumers { get; set; } = new List<Costumer>();
    }
}