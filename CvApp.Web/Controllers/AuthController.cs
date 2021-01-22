using CvApp.Business.Interfaces;
using CvApp.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvApp.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAppUserService appUserService;
        public AuthController(IAppUserService appUserService)
        {
            this.appUserService = appUserService;
        }
        public IActionResult Login()
        {
            return View(new AppUserLoginModel());
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme).Wait();
            return RedirectToAction("Index", "Home", new { @area = "" });
        }


        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginModel model)
        {
            if (ModelState.IsValid)
            {
                if(appUserService.CheckUser(model.UserName, model.Password))
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, model.UserName),
                        new Claim(ClaimTypes.Role, "Admin"),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = model.RememberMe
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),authProperties);

                    return RedirectToAction("Index", "Home", new { @area = "Admin" });
                }
                    
                ModelState.AddModelError("", "Kullanıcı adı veya parola hatalı");
            }
            return View(model);
        }
    }
}
