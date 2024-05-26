using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MF.ERP.Web.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public QuestionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.cUser = "1";
            QuestionVM questionVM = new QuestionVM()
            {
                cUser = 1,
                IndustryIdList = await slIndustry()
            };
            return View(questionVM);
        }
        [HttpPost]
        public IActionResult Create(QuestionVM entity)
        {
            if (entity.Id == 0)
                ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Question>(entity);
                if (entity.Id != 0)
                    _unitOfWork.QuestionRepository.Update(mapedEntity);
                else
                    _unitOfWork.QuestionRepository.Add(mapedEntity);

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
            var enties = await _unitOfWork.QuestionRepository.GetAllAsync(
                include: x => x.Include(z => z.Industry!));
            var mapedEntites = _mapper.Map<List<QuestionVM>>(enties);
            return Json(mapedEntites);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.QuestionRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.QuestionRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.QuestionRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slIndustry()
        {
            var items = await _unitOfWork.IndustryRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
