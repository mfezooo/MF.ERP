using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionsController(IUnitOfWork unitOfWork, IMapper mapper)
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
        public IActionResult Create(QuestionVM entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Question>(entity);
                _unitOfWork.QuestionRepository.Add(mapedEntity);
                int savedCount = _unitOfWork.Save();
                if (savedCount > 0)
                    return Json(new { isSuccess = true, message = "Created Successfuly", id = mapedEntity.Id, customerName = mapedEntity.NameAr });
                return Json(new { isSuccess = true, message = "Error in saving", id = 0, customerName = "" });

            }
            return Json(new { isSuccess = false, message = "Error in Creation" });
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var enties = await _unitOfWork.QuestionRepository.GetAllAsync();
            return Json(enties);
        }
    }
}
