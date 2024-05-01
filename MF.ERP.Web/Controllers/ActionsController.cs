using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class ActionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
