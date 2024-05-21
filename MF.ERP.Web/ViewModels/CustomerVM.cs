using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web
{
    public class CustomerVM : BaseClassWithNameArEnVM
    {
        public int CustomerId { get; set; }
        public string Email { get; set; } = string.Empty;
        public TimeSpan WarehouseAvilableTill { get; set; }  
        public string Address { get; set; } = string.Empty;
        public string Note { get; set; } = string.Empty;
        public string CompaniesCompetation { get; set; } = string.Empty;
        public int Periority { get; set; }
        public int PaymentAllowedDays { get; set; } 
        public int CustomerTypeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsBlocked { get; set; } 
        public string EndReason { get; set; } = string.Empty;
        public int AreaId { get; set; }
        public int IndustryId { get; set; }
        public int StatusId { get; set; }
        public int RepresentiveId { get; set; } 
        public int GroupId { get; set; } 
        public List<SelectListItem>? GroupList { get; set; } 
        public List<SelectListItem>? CustomerTypeList { get; set; } 
        public List<SelectListItem>? AreaList { get; set; }
        public List<SelectListItem>? IndustryList { get; set; }
        public List<SelectListItem>? LastStatusList { get; set; }
        public List<SelectListItem>? RepresentiveList { get; set; } 
    }
}
