namespace MF.ERP.Models
{
    public class PaymentPlanDetails : BaseEntity 
    { 
        public int GovernmentIdGovernmentId { get; set; }  
        public decimal Ammount { get; set; }  
        public int PaymentMethoud { get; set; }  
        public DateTime DueDate { get; set; }  
        public DateTime PaiedDate { get; set; }  
        public int ResetNumber { get; set; }
        public string Note { get; set; } = string.Empty;
    }
}
