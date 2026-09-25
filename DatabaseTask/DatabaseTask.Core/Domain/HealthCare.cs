namespace DatabaseTask.Core.Domain
{
    public class HealthCare
    {
        public Guid Id { get; set; }
        public string AbsenceReason { get; set; }
        public DateTime History { get; set; }

        // Foreign key to Employee
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}