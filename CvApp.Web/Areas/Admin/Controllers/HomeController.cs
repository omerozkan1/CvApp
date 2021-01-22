using AutoMapper;
using CvApp.Business.Interfaces;
using CvApp.DTO.DTOs.AppUserDtos;
using CvApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CvApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin,Member")]
    public class HomeController : Controller
    {
        private readonly IAppUserService appUserService;
        public HomeController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }
        public IActionResult Index()
        {
            TempData["active"] = "bilgilerim";
            var user = appUserService.FindByName(User.Identity.Name);
            var appUserUpdateModel = new AppUserUpdateModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                ShortDescription = user.ShortDescription,
                ImageUrl = user.ImageUrl
            };   
            return View(appUserUpdateModel);
        }

        [HttpPost]
        public IActionResult Index(AppUserUpdateModel model)
        {
            TempData["active"] = "bilgilerim";
            if (ModelState.IsValid)
            {
                var updatedAppUser = appUserService.GetById(model.Id);
                if (model.Picture != null)
                {
                    var imgName = Guid.NewGuid() + Path.GetExtension(model.Picture.FileName);
                    var path = Directory.GetCurrentDirectory() + "/wwwroot/img/" + imgName;
                    var stream = new FileStream(path, FileMode.Create);
                    model.Picture.CopyTo(stream);
                    updatedAppUser.ImageUrl = imgName;
                }
                updatedAppUser.LastName = model.LastName;
                updatedAppUser.FirstName = model.FirstName;
                updatedAppUser.PhoneNumber = model.PhoneNumber;
                updatedAppUser.ShortDescription = model.ShortDescription;
                updatedAppUser.Address = model.Address;
                updatedAppUser.Email = model.Email;

                appUserService.Update(updatedAppUser);
                TempData["message"] = "İşleminiz başarıyla gerçekleşti";

                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        
        public IActionResult ChangePassword()
        {
            TempData["active"] = "sifre";
            return View();
        }
    }
}
