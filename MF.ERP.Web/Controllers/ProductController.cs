using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
