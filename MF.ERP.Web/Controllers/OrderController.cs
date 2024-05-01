using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
