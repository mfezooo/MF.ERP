using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Runtime.ConstrainedExecution;

namespace MF.ERP.Web.Controllers
{
    public class RepresintiveTargetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RepresintiveTargetController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.cUser = "1";
            RepresintiveTargetVM represintiveTargetVM = new RepresintiveTargetVM()
            {
                cUser = 1,
                RepresentiveIdList= await slRepresentive(),
                TartgetTypeIdList = await slTartgetType()
            };
            return View(represintiveTargetVM);
        }
        [HttpPost]
        public IActionResult Create(RepresintiveTargetVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<RepresintiveTarget>(entity);
                _unitOfWork.RepresintiveTargetRepository.Add(mapedEntity);
                int savedCount = _unitOfWork.Save();
                if (savedCount > 0)
                    return Json(new { isSuccess = true, message = "Created Successfuly", id = mapedEntity.Id, data = mapedEntity });
                return Json(new { isSuccess = true, message = "Error in saving", id = 0, data = "" });

            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.RepresintiveTargetRepository.GetAllAsync();
            return Json(enties);
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slRepresentive()
        {
            var items = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slTartgetType()
        {
            var items = await _unitOfWork.TargetTypeRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
