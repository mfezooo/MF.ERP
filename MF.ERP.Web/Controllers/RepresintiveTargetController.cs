using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
                TargetTypeIdList = await slTargetType()
            };
            return View(represintiveTargetVM);
        }
        [HttpPost]
        public IActionResult Create(RepresintiveTargetVM entity)
        {
            if (entity.Id == 0)
                ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<RepresintiveTarget>(entity);
                if (entity.Id != 0)
                    _unitOfWork.RepresintiveTargetRepository.Update(mapedEntity);
                else
                    _unitOfWork.RepresintiveTargetRepository.Add(mapedEntity);

                int savedCount = _unitOfWork.Save();
                 if (savedCount > 0)
                    return Json(new { isSuccess = true, message = "Created Successfuly" });
                return Json(new { isSuccess = true, message = "Error in saving" });

            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.RepresintiveTargetRepository.GetAllAsync(
                include: x => x.Include(z => z.TargetType!).Include(w=>w.Representive!));
            var mapedEntites = _mapper.Map<List<RepresintiveTargetVM>>(enties);
            return Json(mapedEntites);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.RepresintiveTargetRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.RepresintiveTargetRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.RepresintiveTargetRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slRepresentive()
        {
            var items = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slTargetType()
        {
            var items = await _unitOfWork.TargetTypeRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
