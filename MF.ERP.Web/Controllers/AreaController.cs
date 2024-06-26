﻿using AutoMapper;
using MF.ERP.DataAccess;
using MF.ERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            if (entity.Id == 0)
                ModelState.Remove("id");
            if (ModelState.IsValid)
            {
                var mapedEntity = _mapper.Map<Area>(entity);
                if (entity.Id != 0)
                    _unitOfWork.AreaRepository.Update(mapedEntity);
                else
                    _unitOfWork.AreaRepository.Add(mapedEntity);

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
            var enties = await _unitOfWork.AreaRepository.GetAllAsync(
                include:x=>x.Include(z=>z.Government!));
            var mapedEntites = _mapper.Map<List<AreaVM>>(enties); 
            return Json(mapedEntites);
        }
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var enties = await _unitOfWork.AreaRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            return Json(enties);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var enties = await _unitOfWork.AreaRepository.GetFirstOrDefaultAsync(x => x.Id == id);
            _unitOfWork.AreaRepository.Remove(enties!);
            int savedCount = _unitOfWork.Save();
            if (savedCount > 0)
                return Json(new { isSuccess = true, message = "Deleted Successfuly" });
            return Json(new { isSuccess = true, message = "Error in saving" });
        }
        [HttpGet]
        public async Task<List<SelectListItem>?> slGoverments()
        {
            var items = await _unitOfWork.GovernmentRepository.GetAllAsync();
            return items.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.NameAr }).ToList();
        }
    }
}
