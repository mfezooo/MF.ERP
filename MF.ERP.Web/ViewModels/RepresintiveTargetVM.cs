using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web
{
    public class RepresintiveTargetVM : BaseClassWithNameArEnVM
    {
        public int RepresentiveId { get; set; }
        public string RepresentiveName { get; set; } = string.Empty;
        public string TargetTypeName { get; set; } = string.Empty;
        public DateTime StartTargetTime { get; set; }
        public string StartTargetTimeStr => StartTargetTime.Date.ToShortDateString();
        public DateTime EndTargetTime { get; set; }
        public string EndTargetTimeStr => EndTargetTime.Date.ToShortDateString();
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TargetTypeId { get; set; }
        public int cUser { get; set; }
        public List<SelectListItem>? RepresentiveIdList { get; set; }
        public List<SelectListItem>? TargetTypeIdList { get; set; }

        //public Representive Representive { get; set; } = null!;  
    }
}
