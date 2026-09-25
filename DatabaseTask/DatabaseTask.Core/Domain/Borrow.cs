namespace DatabaseTask.Core.Domain
{
    public class Borrow
    {
        public Guid Id { get; set; }
        public DateTime BorrowingDate { get; set; }
        public DateTime BorrowingStartDate { get; set; }
        public DateTime BorrowingEndDate { get; set; }
        public string History { get; set; }

        // Foreign keys
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public Guid ItemOwnedByCompanyId { get; set; }
        public ItemOwnedByCompany ItemOwnedByCompany { get; set; }
    }
}