namespace UNISD.Entities
{
    public class Upgrade
    {
        public  Guid Id { get; set; }

        public Guid EmployeeId { get; set; }
        public Guid ItemId { get; set; }

        public int Ram { get; set; }
        public int Ssd { get; set; }
        public DateTime Date { get; set; }








        public virtual Employee Employee { get; set; }
        public virtual Item Item { get; set; }


    }
}
