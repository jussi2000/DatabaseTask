using System.Collections;

namespace DatabaseTask.Core.Domain
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation properties
        public ICollection Employees { get; set; }
        public ICollection Intranets { get; set; }
        public ICollection ItemsOwnedByCompany { get; set; }
    }
}