using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Inmate
    {
        [Key]
        public int InmateId { get; set; }

        [Required]
        public int CellId { get; set; }
        public Cell Cell { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public string PersonalCode { get; set; }

        public DateTime ArrivalDate { get; set; }

        [Required]
        public string Status { get; set; }

        public ICollection<InmateCrime> InmateCrimes { get; set; } = new List<InmateCrime>();
        public ICollection<Sentence> Sentences
        {
            get; set;
        } = new List<Sentence>();
    }
}
