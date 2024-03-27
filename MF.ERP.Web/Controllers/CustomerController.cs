using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewVisits()
        {
            return View();
        }
         
    }
}
