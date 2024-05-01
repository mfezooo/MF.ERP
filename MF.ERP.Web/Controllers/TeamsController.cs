using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
