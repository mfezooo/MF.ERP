using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
