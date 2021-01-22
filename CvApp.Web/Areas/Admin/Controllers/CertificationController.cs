using AutoMapper;
using CvApp.Business.Interfaces;
using CvApp.DTO.DTOs.CertificationDtos;
using CvApp.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CertificationController : Controller
    {
        private readonly IGenericService<Certification> certificationService;
        private readonly IMapper mapper;

        public CertificationController(IGenericService<Certification> certificationService, IMapper mapper)
        {
            this.certificationService = certificationService;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            TempData["active"] = "sertifika";
            return View(mapper.Map<List<CertificationListDto>>(certificationService.GetAll()));
        }

        public IActionResult Delete(int id)
        {
            TempData["active"] = "sertifika";
            var deletedEntity = certificationService.GetById(id);
            certificationService.Delete(deletedEntity);

            TempData["message"] = "Sertifika silindi.";
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add()
        {
            TempData["active"] = "sertifika";
            return View(new CertificationAddDto());
        }

        [HttpPost]
        public IActionResult Add(CertificationAddDto model)
        {
            TempData["active"] = "sertifika";

            if (ModelState.IsValid)
            {
                certificationService.Insert(mapper.Map<Certification>(model));
                TempData["message"] = "Sertifika eklendi.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


        public IActionResult Update(int id)
        {
            TempData["active"] = "sertifika";
            return View(mapper.Map<CertificationUpdateDto>(certificationService.GetById(id)));
        }

        [HttpPost]
        public IActionResult Update(CertificationUpdateDto model)
        {
            TempData["active"] = "sertifika";
            if (ModelState.IsValid)
            {
                var updatedCertification = certificationService.GetById(model.Id);
                updatedCertification.Description = model.Description;
                certificationService.Update(updatedCertification);
                TempData["message"] = "Güncelleme işlemi başarılı.";
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
