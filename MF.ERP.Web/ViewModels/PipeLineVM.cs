namespace MF.ERP.Web
{
    public class PipeLineVM : BaseClassWithNameArEnVM
    {
        public int CustomerId { get; set; }
        public int? OrderId { get; set; }
        public decimal ActiExpectedRevenueonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpectedEndDate { get; set; }
        public int StatusId { get; set; }
    }
}
