using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class GuardShift
    {
        [Key]
        public int GuardShiftId { get; set; } //(PK - Guardshift_Id(INT))

        [Required] //Side guardId ning guard'i vahel - (guard_id (INT))
        public int GuardId { get; set; }
        public Guard Guard { get; set; } 

        [Required] //Side ShiftId ning shift'i vahel - (shift_id (INT))
        public int ShiftId { get; set; }
        public Shift Shift { get; set; }
    }
}
