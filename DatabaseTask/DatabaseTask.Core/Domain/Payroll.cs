using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Payroll
    {
        [Key]
        public Guid Id { get; set; }
        public float Amount { get; set; }
        public DateTime Date { get; set; }

        public Employee Employee { get; set; }
    }
}
