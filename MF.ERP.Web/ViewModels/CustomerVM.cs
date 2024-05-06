using MF.ERP.Web.ViewModels.BaseVM;
using System.ComponentModel.DataAnnotations;
namespace MF.ERP.Service.DTO
{
    public class CustomerVM : BaseClassVM
    {
        
        public string Email { get; set; } = string.Empty;
        public DateTime WarehouseAvilableTill { get; set; }  
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
        
    }
}
