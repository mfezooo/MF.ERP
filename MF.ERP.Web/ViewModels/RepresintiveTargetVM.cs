using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web
{
    public class RepresintiveTargetVM : BaseClassWithNameArEnVM
    {
        public int RepresentiveId { get; set; }
        public string RepresentiveName { get; set; } = string.Empty;
        public string TartgetTypeName { get; set; } = string.Empty;
        public DateTime StartTartgetTime { get; set; }
        public DateTime EndTartgetTime { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountAtEndOfDuration { get; set; }
        public int? TartgetTypeId { get; set; }
        public int cUser { get; set; }
        public List<SelectListItem>? RepresentiveIdList { get; set; }
        public List<SelectListItem>? TartgetTypeIdList { get; set; }

        //public Representive Representive { get; set; } = null!; 
        //public TartgetType? TartgetType { get; set; }
    }
}
