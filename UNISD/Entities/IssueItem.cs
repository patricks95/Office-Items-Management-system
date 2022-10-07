using System.ComponentModel.DataAnnotations;

namespace UNISD.Entities
{
    public class IssueItem
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public Guid ItemId { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

       

        public virtual Employee Employee { get; set; }
        public virtual Item Item { get; set; }


    }
}
