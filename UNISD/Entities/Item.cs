using System.ComponentModel.DataAnnotations;

namespace UNISD.Entities
{
    public class Item
    {
        
        [Key]
        [Required]
        public Guid Id { get; set; } 

        public string Name { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public string Processor { get; set; }
        [Required]
        public int Gen { get; set; }
        [Required]
        public int Ram { get; set; }
        [Required]
        public string RamType { get; set; }
        public int RamSpeed { get; set; }
        [Required]
        public int Ssd { get; set; }
        public int Hdd { get; set; }
        [Required]
        public DateTime PurchDate { get; set; }
        [Required]
        public int warrantyYear { get; set; }
        public Boolean Status { get;set; }




    }
}
