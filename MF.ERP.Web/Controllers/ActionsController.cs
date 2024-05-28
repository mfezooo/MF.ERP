using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MF.ERP.Web.Controllers
{
    public class ActionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ActionsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ActionsMasterVM vm = new ActionsMasterVM()
            {
                UserCreated = "1",
                RepresentiveList = await GetallRepresentive(),
                ActionDate = DateTime.Now,
                ActionDateDetails = DateTime.Now,
                NextActionDate = DateTime.Now
                
            };
            ViewBag.Customer = await GetallCustomer();
            ViewBag.ActionType = await GetallActionType();
            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(ActionsMasterVM entity)
        {
            if (entity.Id == 0)
                ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<ActionsMaster>(entity);
                if (entity.Id != 0)
                    _unitOfWork.ActionsRepository.Update(mapedEntity);
                else
                    _unitOfWork.ActionsRepository.Add(mapedEntity);

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
            var enties = await _unitOfWork.ActionsRepository.GetAllAsync(
                include: x => x.Include(z => z.Representive!).Include(q=>q.Details!).ThenInclude(q=>q.Customer!));
            var mapedEntites = _mapper.Map<List<AreaVM>>(enties);
            return Json(mapedEntites);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.ActionsRepository.GetFirstOrDefaultAsync(x => x.Id == id,
                include: x => x.Include(z => z.Representive!).Include(q => q.Details!).ThenInclude(q => q.Customer!));
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.ActionsRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.ActionsRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> GetallRepresentive()
        {
            // عمل صلاحية لتحديد المندوب اللى مربوط على المستخدم فقط لاظهاره فى الشاشة ولو هو مدير يظهر الكل 
            var items = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }

        [HttpGet]
        public async Task<List<SelectListItem>?> GetallCustomer()
        {
            // عمل صلاحية لتحديد العميل اللى مربوط على المستخدم فقط لاظهاره فى الشاشة ولو هو مدير يظهر الكل 
            var items = await _unitOfWork.CustomerRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }

        [HttpGet]
        public async Task<List<SelectListItem>?> GetallActionType()
        {

            var items = await _unitOfWork.ActionTypeRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
