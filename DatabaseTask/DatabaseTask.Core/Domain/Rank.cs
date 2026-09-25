using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Rank
    {
        [Key]
        public int Rank_ID { get; set; }

        public int? Employee_ID { get; set; }
        [ForeignKey(nameof(Employee_ID))]
        public Employee? Employee { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;
    }
}