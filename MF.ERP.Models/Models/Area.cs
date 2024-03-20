namespace MF.ERP.Models
{
    public class Area : BaseEntityWithNameArEn
    { 
        public int GovernmentId { get; set; } 
        public Government? Government { get; set; }  
    }
    public class Government : BaseEntityWithNameArEn
    { 
        public virtual IEnumerable<Area>? Areas { get; set; }
    }
    public class Question : BaseEntityWithNameArEn
    {
        public int IndustryId { get; set; }
    }
    public class VisitStatus: BaseEntityWithNameArEn
    { 
    }
    public class Action : BaseEntityWithNameArEn
    { 
    }
    public class Visit : BaseEntity 
    { 
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public Action? Action { get; set; }
        public int? NextActionId { get; set; }
        public Action? NextAction  { get; set; }
        public DateTime? NextActionDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public int RepresentiveId { get; set; }
        public Representive Representive { get; set; }
        public int? VisitRefranceId { get; set; }
        public int? OfferPriceId { get; set; }
        public int? PurchasingOrderId { get; set; }
        public int? StatusId { get; set; }
        public bool? isConsumeRecorded { get; set; }
        public string Result { get; set; } =string.Empty;
        public bool? IsApprovedByManager { get; set; }
        public string LocationWhenWithCustomer { get; set; } =string.Empty;
    }
}
