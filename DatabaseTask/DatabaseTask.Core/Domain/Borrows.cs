using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Borrows
    {
        [Key]
        public int Borrows_ID { get; set; }

        public int? Items_owned_by_company_ID { get; set; }
        [ForeignKey(nameof(Items_owned_by_company_ID))]
        public Items_owned_by_company? ItemsOwnedByCompany { get; set; }

        public int? Employee_ID { get; set; }
        [ForeignKey(nameof(Employee_ID))]
        public Employee? Employee { get; set; }

        public DateTime Borrowing_date { get; set; }
        public DateTime Borrowing_start_date { get; set; }
        public DateTime Borrowing_end_date { get; set; }
        public DateTime History { get; set; }
    }
}