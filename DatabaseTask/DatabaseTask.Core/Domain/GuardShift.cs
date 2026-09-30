using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class GuardShift
    {
        [Key]
        public int GuardShiftId { get; set; }

        [Required] 
        public int GuardId { get; set; }
        public Guard Guard { get; set; } 

        [Required]
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}
