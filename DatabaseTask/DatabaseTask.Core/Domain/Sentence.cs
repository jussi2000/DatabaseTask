using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Sentence
    {
        [Key]
        public int SentenceId { get; set; }

        [Required]
        public int InmateId { get; set; }
        public Inmate Inmate { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        public string SentenceType { get; set; }

    }
}
