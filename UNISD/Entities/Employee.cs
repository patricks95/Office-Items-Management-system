using System.ComponentModel.DataAnnotations;

namespace UNISD.Entities
{
    public class Employee
    {

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Nic { get; set; }

        [Required]
        public int Mobile { get; set; }

        [Required]
        public string position { get; set; }

        public string TeamName { get; set; }


        public List<IssueItem> IssueItems { get; set; }
    }
}
