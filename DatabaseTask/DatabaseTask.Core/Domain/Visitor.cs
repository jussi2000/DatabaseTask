using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Visitor
    {
        [Key]
        public int VisitorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PersonalCode { get; set; }

        public string Phone { get; set; }

        [Required]
        public string Relationship { get; set; }

        public ICollection<Visit> Visits { get; set; } = new List<Visit>();
    }
}
