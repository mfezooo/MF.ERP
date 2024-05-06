namespace MF.ERP.Models.Models
{
    public class PipeLineStatus : BaseEntityWithNameArEn
    {
        public int CustomerId { get; set; }
        public int? ProductId { get; set; }
        public int ProductName { get; set; }
        public decimal Quantity { get; set; }
    }

}
