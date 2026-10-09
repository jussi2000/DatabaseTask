using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Terminal
    {
        [Key]
        public Guid Terminal_ID { get; set; }
        public string Terminal_Nr { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<Employee> Employees { get; set; }
              = new List<Employee>();
        public ICollection<Airport> Airports { get; set; }
      = new List<Airport>();
    }
}
