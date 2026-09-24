using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Crime
    {
        [Key]
        public int CrimeId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; } //Võib olla tühi ehk siis NULL

        [Required]
        public string SeverityLevel { get; set; }
        public ICollection<InmateCrime> InmateCrimes { get; set; } = new List<InmateCrime>();
    }
}
