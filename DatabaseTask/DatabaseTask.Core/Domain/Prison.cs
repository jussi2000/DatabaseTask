using System.ComponentModel.DataAnnotations;
namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        [Key]
        public int PrisonId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }
        public int MaxCapacity { get; set; }
        public ICollection<Block> Blocks { get; set; } = new List<Block>();
    }
}
