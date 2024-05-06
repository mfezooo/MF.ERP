namespace MF.ERP.Models.Models
{
    public class PipeLine : BaseEntity 
    {
        public int CustomerId { get; set; }
        public int? OrderId { get; set; }
        public decimal ActiExpectedRevenueonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public int StatusId { get; set; }
        public virtual IEnumerable<PineLineAction>? PineLineActions { get; set; }


    }

}
