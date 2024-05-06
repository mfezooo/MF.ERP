namespace MF.ERP.Web
{
    public class PipeLineStatusVM : BaseClassWithNameArEnVM
    {
        public int CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int ProductName { get; set; }
        public decimal Quantity { get; set; }
    }
}
