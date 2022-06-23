using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;


namespace HikikomoriWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        private readonly IRemember _remember;
        //private readonly IRestAPI _request;
        public HomeController(IContent con, ICategory cat, IRemember rem/*, IRestAPI req*/)
        {
            _content = con;
            _category = cat;
            _remember = rem;
            //_request = req;
        }
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult SidebarPartial()
        //{
        //    var data = _request.GetQuote();
        //    ViewData["Quote"] = data["quote"].Value<string>();
        //    ViewData["Character"] = data["character"].Value<string>();
        //    ViewData["Show"] = data["show"].Value<string>();
        //    return View();
        //}

        #region ФОРМЫ НА ГЛАВНОЙ СТРАНИЦЕ

        [HttpGet]
        public IActionResult RateContent() //оценить
        {
            ViewBag.Categ = new SelectList(_category.GetCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult RateContent(Content objCon) //оценить
        {
            if (ModelState.IsValid)
            {
                _content.SaveContent(objCon);
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult RememberContent() //запомнить
        {
            ViewBag.Categ = new SelectList(_category.GetCategories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult RememberContent(Remember obj) //запомнить
        {
            if (ModelState.IsValid)
            {
                _remember.SaveRemember(obj);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        #endregion
    }
}
