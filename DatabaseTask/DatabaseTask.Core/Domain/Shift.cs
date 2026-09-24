using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Shift
    {
        [Key]
        public int ShiftId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }
        public ICollection<GuardShift> GuardShifts { get; set; } = new List<GuardShift>();
    }
}
