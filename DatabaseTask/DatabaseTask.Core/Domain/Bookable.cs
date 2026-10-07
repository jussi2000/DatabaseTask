using System.ComponentModel.DataAnnotations;

namespace DatabaseTask.Core.Domain
{
    public class Bookable
    {
        [Key]
        public Guid Id { get; set; }
        public string ExtraInfo { get; set; }
        public string Status { get; set; }


    }
}
