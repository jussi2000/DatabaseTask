using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Child
    {
        [Key]
        public int Child_ID { get; set; }

        public int? Employee_ID { get; set; }
        [ForeignKey(nameof(Employee_ID))]
        public Employee? Employee { get; set; }

        [Required]
        [MaxLength(50)]
        public string First_name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Last_name { get; set; } = string.Empty;
    }
}