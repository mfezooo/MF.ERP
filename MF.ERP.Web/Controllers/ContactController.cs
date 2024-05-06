using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create(CustomerType entity)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _unitOfWork.CustomerTypeRepository.Add(entity);
        //        _unitOfWork.Save();
        //        return Json(new { isSuccess = true, message = "Created Successfuly" });
        //    }
        //    return Json(new { isSuccess = false, message = "Error in Creation" });
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var enties = await _unitOfWork.CustomerTypeRepository.GetAllAsync();
        //    return Json(enties);
        //}
    }
}
