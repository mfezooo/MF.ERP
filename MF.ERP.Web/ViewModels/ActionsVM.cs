using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web
{
    public class ActionsMasterVM : BaseClassVM
    {
        public int RepresentiveId { get; set; }
        public DateTime ActionDate { get; set; }
        public string? Notes { get; set; }
        public List<SelectListItem>? RepresentiveList { get; set; }
        public virtual RepresentiveVM Representive { get; set; } = null!;
        public virtual ICollection<ActionsDetailsVM>? Details { get; set; }


        public int? CustomerId { get; set; }
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActionId { get; set; }
        public DateTime? ActionDateDetails { get; set; }
        public ActionTypeVM? ActionType { get; set; }
        public int? NextActionId { get; set; }
        public ActionTypeVM? NextActionTpe { get; set; }
        public DateTime? NextActionDate { get; set; }
        public string Result { get; set; } = string.Empty;

    }
    public class ActionsDetailsVM : BaseClassVM
    {
        public int ActionsMasterId { get; set; }
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; }
        public int? ActionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public ActionTypeVM? ActionType { get; set; }
        public int? NextActionId { get; set; }
        public ActionTypeVM? NextActionTpe { get; set; }
        public DateTime? NextActionDate { get; set; }
        public int CustomerId { get; set; }
        public int? ActionRefranceId { get; set; }
        public int? OfferPriceId { get; set; }
        public int? PurchasingOrderId { get; set; }
        public int? StatusId { get; set; }
        public bool? isConsumeRecorded { get; set; }
        public string Result { get; set; } = string.Empty;
        public bool? IsApprovedByManager { get; set; }
        public string LocationWhenWithCustomer { get; set; } = string.Empty;
        public virtual ActionsMasterVM ActionsMaster { get; set; } = null!;
        public virtual CustomerVM Customer { get; set; } = null!;
    }
}
