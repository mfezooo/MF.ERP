using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MF.ERP.Web.Controllers
{
    public class RepresentiveController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public RepresentiveController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            RepresentiveVM vm = new RepresentiveVM()
            {
                UserCreated = "1", 
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult Create(RepresentiveVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Representive>(entity);
                _unitOfWork.RepresentiveRepository.Add(mapedEntity);
                int savedCount = _unitOfWork.Save();
                if (savedCount > 0)
                    return Json(new { isSuccess = true, message = "Created Successfuly", id = mapedEntity.Id, RepresentiveName = mapedEntity.NameAr });
                return Json(new { isSuccess = true, message = "Error in saving", id = 0, RepresentiveName = "" });

            }
            return Json(new { isSuccess = false, message = "Error in Creation", id = 0, RepresentiveName = "" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.RepresentiveRepository.GetAllAsync();
            return Json(enties);
        }
        
    }
}
