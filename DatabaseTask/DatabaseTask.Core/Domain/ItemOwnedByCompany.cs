using System.Collections;

namespace DatabaseTask.Core.Domain
{
    public class ItemOwnedByCompany
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        // Foreign key to Company
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection Borrows { get; set; }
    }
}