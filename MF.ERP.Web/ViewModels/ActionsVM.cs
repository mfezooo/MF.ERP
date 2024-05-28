using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace MF.ERP.Web
{
    public class ActionsMasterVM : BaseClassVM
    {
        public int cUser { get; set; } 
        public string? Notes { get; set; } 
        public decimal ExpectedRevenue { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? ExpectedEndDate { get; set; } = DateTime.Now;
        public int ActionStatusId { get; set; } 

        public int RepresentiveId { get; set; } 
        public int CustomerId { get; set; }
        public string RepresentiveName { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;


        public int? ActionRefranceId { get; set; } 

        public int? OfferPriceId { get; set; }
        public int? PurchasingOrderId { get; set; }
        public int? OrderId { get; set; }

        public  List<ActionsDetails>? Details { get; set; }
        public List<SelectListItem>? RepresentiveList { get; set; }
        public List<SelectListItem>? CustomerList { get; set; }
        public List<SelectListItem>? ActionStatusList { get; set; }
        public List<SelectListItem>? ActionTypeList { get; set; }
        public List<SelectListItem>? ActionDetailStatusList { get; set; }

    }
    public class ActionsDetailsVM : BaseClassVM
    {
        public int Id { get; set; } = 0;
        public int UserCreated { get; set; } = 0;
        public int ActionsMasterId { get; set; } = 0;
        public DateTime? PlanedDate { get; set; }
        public DateTime? ActualDate { get; set; } = DateTime.Now;
        public int? ActionId { get; set; }
        public DateTime? ActionDate { get; set; }
        public int? ActionTypeId { get; set; } 
        public int? NextActionId { get; set; } 
        public DateTime? NextActionDate { get; set; }
        public int? ActionDetailStatusId { get; set; } 
        public bool? isConsumeRecorded { get; set; }
        public string Result { get; set; } = string.Empty;
        public bool? IsApprovedByManager { get; set; }
        public string LocationWhenWithCustomer { get; set; } = string.Empty; 
        public string ActionDetailStatusName { get; set; } = string.Empty;
    }
}
