using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class CustomerTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerTypeController(IUnitOfWork unitOfWork , IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult Create(CustomerTypeVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<CustomerType>(entity);
                _unitOfWork.CustomerTypeRepository.Add(mapedEntity);
                _unitOfWork.Save();
                return Json(new { isSuccess = true, message = "Created Successfuly" });
            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.CustomerTypeRepository.GetAllAsync();
            return Json(enties);
        }
    }
}
