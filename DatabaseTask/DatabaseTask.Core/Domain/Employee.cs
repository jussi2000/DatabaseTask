using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Employee_ID { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Employee_Nr { get; set; }
        public string Tel { get; set; }
        public string Position { get; set; }
    }
}
