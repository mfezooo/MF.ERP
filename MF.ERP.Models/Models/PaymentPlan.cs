namespace MF.ERP.Models
{
    public class PaymentPlan : BaseEntity 
    { 
        public int OrderId { get; set; } 
        public int PaymentCount { get; set; }   
        public decimal EveryPaymentAmmount { get; set; }  
    }   
}
