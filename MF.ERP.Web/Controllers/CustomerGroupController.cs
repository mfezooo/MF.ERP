using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class CustomerGroupController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerGroupController(IUnitOfWork unitOfWork, IMapper mapper)
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
        public IActionResult Create(CustomerGroupVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<CustomerGroup>(entity);
                _unitOfWork.CustomerGroupRepository.Add(mapedEntity);
                _unitOfWork.Save();
                return Json(new { isSuccess = true, message = "Created Successfuly" });
            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.CustomerGroupRepository.GetAllAsync();
            return Json(enties);
        }
    }
}
