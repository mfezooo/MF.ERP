using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
