using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class InmateCrime
    {
        [Key]
        public int InmateCrimeId { get; set; }

        [Required]
        public int InmateId { get; set; }
        public Inmate Inmate { get; set; }

        [Required]
        public int CrimeId { get; set; }
        public Crime Crime { get; set; }
    }
}
