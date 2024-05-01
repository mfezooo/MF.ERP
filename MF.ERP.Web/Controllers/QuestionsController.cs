using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class QuestionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
