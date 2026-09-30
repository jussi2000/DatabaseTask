using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        [Key]
        public int BlockId { get; set; }

        [Required]
        public int PlaceId { get; set; }
        public int PrisonId { get; set; }
        public Prison Prison { get; set; }

        [Required]
        public string BlockNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SecurityLevel { get; set; }
        public ICollection<Cell> Cells { get; set; } = new List<Cell>();
    }
}
