using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MF.ERP.Web.Controllers
{
    public class JobController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public JobController(IUnitOfWork unitOfWork, IMapper mapper)
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
        public IActionResult Create(JobVM entity)
        {
            if (entity.Id == 0)
                ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Job>(entity);
                if (entity.Id != 0)
                    _unitOfWork.JobRepository.Update(mapedEntity);
                else
                    _unitOfWork.JobRepository.Add(mapedEntity);

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
            var enties = await _unitOfWork.JobRepository.GetAllAsync();
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.JobRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.JobRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.JobRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
    }
}
