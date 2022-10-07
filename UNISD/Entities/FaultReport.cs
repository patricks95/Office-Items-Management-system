namespace UNISD.Entities
{
    public class FaultReport
    {
        public Guid Id { get; set; }
        public string Details { get; set; }
        public Boolean Status { get; set; }
        public string DoneBy { get; set; }
        public Guid ShopDetailId { get; set; }
        public string JobNumber { get; set; }







        public virtual Employee Employee { get; set; }
        public virtual Item Item { get; set; }
        public virtual ShopDetail ShopDetail { get; set; }


    }
}
