using CvApp.Business.Interfaces;
using CvApp.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CvApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenericService<Skill> skillService;
        public HomeController(IGenericService<Skill> skillService)
        {
            this.skillService = skillService;
        }
        public IActionResult Index()
        {
            return View(skillService.GetAll());
        }
    }
}
