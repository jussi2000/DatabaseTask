using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Cell
    {
        [Key]
        public int CellId { get; set; }
        [Required]

        public int BlockId { get; set; }
  
        public Block Block { get; set; }
        [Required]

        public string CellNumber { get; set; }
        public int Floor { get; set; }
        public int MaxCapacity { get; set; }
        public ICollection<Inmate> Inmates { get; set; } = new List<Inmate>();
    }
}
