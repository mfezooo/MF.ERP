using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CustomerVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Customer>(entity);
                _unitOfWork.CustomerRepository.Add(mapedEntity);
                int savedCount = _unitOfWork.Save();
                if (savedCount > 0)
                    return Json(new { isSuccess = true, message = "Created Successfuly", id = mapedEntity.Id, customerName = mapedEntity.NameAr });
                return Json(new { isSuccess = true, message = "Error in saving", id = 0, customerName = "" });

            }
            return Json(new { isSuccess = false, message = "Error in Creation", id = 0, customerName = "" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.CustomerRepository.GetAllAsync();
            return Json(enties);
        }

        [HttpGet]
        public async Task<List<SelectListItem>?> slCustomerType()
        {
            var items = await _unitOfWork.CustomerTypeRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slArea()
        {
            var items = await _unitOfWork.AreaRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slIndustry()
        {
            var items = await _unitOfWork.IndustryRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slStatus()
        {
            var items = await _unitOfWork.StatusRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slRepresentive()
        {
            var items = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
