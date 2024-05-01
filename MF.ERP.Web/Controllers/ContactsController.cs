using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
