using System.Collections;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhoneNumber { get; set; }

        // Foreign keys & Navigation properties
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection Children { get; set; }
        public ICollection Borrows { get; set; }
        public ICollection Customers { get; set; }

        public ICollection Ranks { get; set; }
        public ICollection HealthCares { get; set; }
    }
}