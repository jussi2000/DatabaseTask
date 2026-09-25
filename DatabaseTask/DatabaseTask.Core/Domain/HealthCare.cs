using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class HealthCare
    {
        [Key]
        public int HealthCare_ID { get; set; }

        public int? Employee_ID { get; set; }
        [ForeignKey(nameof(Employee_ID))]
        public Employee? Employee { get; set; }

        [MaxLength(200)]
        public string Absentee_reason { get; set; } = string.Empty;

        public DateTime History { get; set; }
    }
}