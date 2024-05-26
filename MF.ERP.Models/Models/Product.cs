namespace MF.ERP.Models
{
    public class Product : BaseEntityWithNameArEn
    {
        public string Spects { get; set; } = string.Empty;
        public int? PackId { get; set; }
        public string Pack { get; set; } = string.Empty;
        public decimal SellPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal AvilableQuantity { get; set; }
    }
}
