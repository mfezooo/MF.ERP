using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using MF.ERP.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MF.ERP.Web.Controllers
{
    public class ActionsQuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ActionsQuestionController(IUnitOfWork unitOfWork, IMapper mapper)
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
        public IActionResult Create(ActionsQuestionVm entity)
        {
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<ActionsQuestion>(entity);
                _unitOfWork.ActionsQuestionRepository.Add(mapedEntity);
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
            var enties = await _unitOfWork.ActionsQuestionRepository.GetAllAsync();
            return Json(enties);
        }
    }
}
