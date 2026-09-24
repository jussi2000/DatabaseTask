using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Visit
    {
        [Key]
        public int VisitId { get; set; }

        [Required]
        public int InmateId { get; set; }
        public Inmate Inmate { get; set; }

        [Required]
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [Required]
        public string Status { get; set; }
    }
}
