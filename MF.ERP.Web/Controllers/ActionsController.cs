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
                CustomerList = await GetallCustomer(),
                ActionStatusList = await GetallActionStatus(),
                ActionDetailStatusList = await GetallActionDetailStatusList(),
                ActionTypeList = await GetallActionType(),
                StartDate = DateTime.Now

            };  
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
                    _unitOfWork.ActionsMasterRepository.Update(mapedEntity);
                else
                    _unitOfWork.ActionsMasterRepository.Add(mapedEntity);

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
            var enties = await _unitOfWork.ActionsMasterRepository.GetAllAsync(
                include: x => x.Include(z => z.Representive!).Include(q => q.Customer!).Include(q => q.Details!));
            var mapedEntites = _mapper.Map<List<ActionsMasterVM>>(enties);
            return Json(mapedEntites);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.ActionsMasterRepository.GetFirstOrDefaultAsync(x => x.Id == id,
                include: x => x.Include(z => z.Representive!).Include(q => q.Customer!).Include(q => q.Details!));
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.ActionsMasterRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.ActionsMasterRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> GetallRepresentive(int id = 0)
        {
            // عمل صلاحية لتحديد المندوب اللى مربوط على المستخدم فقط لاظهاره فى الشاشة ولو هو مدير يظهر الكل 

            var items = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            items = id != 0 ? items.Where(x => x.Id == id) : items;
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }

        [HttpGet]
        public async Task<List<SelectListItem>?> GetallCustomer(int representiveId = 0)
        {
            // عمل صلاحية لتحديد العميل اللى مربوط على المستخدم فقط لاظهاره فى الشاشة ولو هو مدير يظهر الكل 
            var items = await _unitOfWork.CustomerRepository.GetAllAsync();
            items = representiveId != 0 ? items.Where(x => x.RepresentiveId == representiveId) : items; 
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }

        [HttpGet]
        public async Task<List<SelectListItem>?> GetallActionType()
        {

            var items = await _unitOfWork.ActionTypeRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> GetallActionStatus()
        {

            var items = await _unitOfWork.ActionStatusRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> GetallActionDetailStatusList()
        {

            var items = await _unitOfWork.ActionDetailStatusRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
