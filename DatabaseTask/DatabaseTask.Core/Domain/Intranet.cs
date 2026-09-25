using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Intranet
    {
        [Key]
        public int Intranet_ID { get; set; }

        public int? Company_ID { get; set; }
        [ForeignKey(nameof(Company_ID))]
        public Company? Company { get; set; }

        public int? Employee_ID { get; set; }
        [ForeignKey(nameof(Employee_ID))]
        public Employee? Employee { get; set; }

        public int? Borrows_ID { get; set; }
        [ForeignKey(nameof(Borrows_ID))]
        public Borrows? Borrows { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
    }
}