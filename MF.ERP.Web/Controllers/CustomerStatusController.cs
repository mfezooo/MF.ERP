using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class CustomerStatusController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerStatusController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            ViewBag.cUser = "1";
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerStatusVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<CustomerStatus>(entity);
                _unitOfWork.CustomerStatusRepository.Add(mapedEntity);
                _unitOfWork.Save();
                return Json(new { isSuccess = true, message = "Created Successfuly" });
            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.CustomerStatusRepository.GetAllAsync();
            return Json(enties);
        }
    }
}
