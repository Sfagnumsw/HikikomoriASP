using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HikikomoriWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        public HomeController(IContent con, ICategory cat)
        {
            _content = con;
            _category = cat;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RateContent() => View();

        [HttpPost]
        public IActionResult RateContent(Content objCon)
        {
            if (ModelState.IsValid)
            {
                _content.SaveContent(objCon);
                return RedirectToAction("Index","Home");
            }
            return View();
        }
    }
}
