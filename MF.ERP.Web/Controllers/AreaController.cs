using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web.Controllers
{
    public class AreaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AreaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            AreaVM vm = new AreaVM()
            {
                UserCreated = "1",
                GovernmentList = await slGoverments()
            }; 
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(AreaVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Area>(entity);
                _unitOfWork.AreaRepository.Add(mapedEntity);
                _unitOfWork.Save();
                return Json(new { isSuccess = true, message = "Created Successfuly" });
            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.AreaRepository.GetAllAsync();
            return Json(enties);
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slGoverments()
        {
            var items = await _unitOfWork.GovernmentRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
