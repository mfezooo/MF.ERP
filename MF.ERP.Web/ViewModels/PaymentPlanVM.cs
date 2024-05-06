namespace MF.ERP.Web
{
    public class PaymentPlanVM : BaseClassWithNameArEnVM
    {
        public int OrderId { get; set; } 
        public int PaymentCount { get; set; }   
        public decimal EveryPaymentAmmount { get; set; }  
    }
}
