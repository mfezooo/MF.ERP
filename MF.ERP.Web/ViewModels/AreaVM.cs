using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MF.ERP.Web
{
    public class AreaVM : BaseClassWithNameArEnVM
    {
        [Required(ErrorMessage ="Should Select Government")]
        public int GovernmentId { get; set; }
        public string GovernmentName { get; set; } = string.Empty;
        public List<SelectListItem>? GovernmentList { get; set; }

    }
}
