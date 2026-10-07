using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class ServiceOrder
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
