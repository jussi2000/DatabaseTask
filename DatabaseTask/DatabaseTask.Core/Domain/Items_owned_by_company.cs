using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Items_owned_by_company
    {
        [Key]
        public int Items_owned_by_company_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Borrows> Borrows { get; set; } = new List<Borrows>();
    }
}