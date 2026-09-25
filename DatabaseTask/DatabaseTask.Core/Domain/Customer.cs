using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Costumer
    {
        [Key]
        public int Costumer_ID { get; set; }

        public int? Employee_ID { get; set; }
        public Employee? Employee { get; set; }

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
    }
}