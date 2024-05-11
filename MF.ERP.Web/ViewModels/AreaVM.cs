using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web
{
    public class AreaVM : BaseClassWithNameArEnVM
    {
        public int GovernmentId { get; set; }
        public List<SelectListItem>? GovernmentList { get; set; }

    }
}
