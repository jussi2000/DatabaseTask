using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Guard
    {
        [Key]
        public int GuardId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EmployeeNumber { get; set; }

        [Required]
        public string Position { get; set; }
        public ICollection<GuardShift> GuardShifts { get; set; } = new List<GuardShift>();
    }
}
