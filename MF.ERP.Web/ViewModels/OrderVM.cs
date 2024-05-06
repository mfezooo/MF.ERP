namespace MF.ERP.Web
{
    public class OrderVM : BaseClassWithNameArEnVM
    {
        public int CustomerId { get; set; }  
        public int RepresintveId { get; set; }  
        public DateTime DeleveryDate { get; set; }  
        public DateTime ValidTo { get; set; }  
        public int PaymentMethodId { get; set; }
        public int PaymentPlanId { get; set; }
        public DateTime OfferPriceDate { get; set; }
        public DateTime ChangeToOrderDate { get; set; }
        public int PipeLineId { get; set; }
        public int CrmMgrApprovedId{ get; set; }
        public DateTime CrmMgrApprovedDate { get; set; }
        public int AccMgrApprovedId{ get; set; }
        public DateTime AccMgrApprovedDate { get; set; } 
        public int StockMgrApprovedId{ get; set; }
        public DateTime StocMgrApprovedDate { get; set; }
        public int StatusId{ get; set; }
    }
}
