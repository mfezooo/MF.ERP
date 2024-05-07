namespace MF.ERP.Web
{
    public class ActionsVM : BaseClassWithNameArEnVM
    {
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? NextActionId { get; set; }
        public DateTime? NextActionDate { get; set; }
        public int CustomerId { get; set; }
        public int RepresentiveId { get; set; }
        public int? ActionRefranceId { get; set; }
        public int? OfferPriceId { get; set; }
        public int? PurchasingOrderId { get; set; }
        public int? StatusId { get; set; }
        public bool? isConsumeRecorded { get; set; }
        public string Result { get; set; } =string.Empty;
        public bool? IsApprovedByManager { get; set; }
        public string LocationWhenWithCustomer { get; set; } =string.Empty;
        //public ActionType? ActionType { get; set; }
        //public ActionType? NextActionTpe  { get; set; }
        //public Customer Customer { get; set; } = null!;
        //public Representive? Representive { get; set; }
    }
}