using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HikikomoriWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        private readonly IRemember _remember;
        public HomeController(IContent con, ICategory cat, IRemember rem)
        {
            _content = con;
            _category = cat;
            _remember = rem;
        }
        public IActionResult Index()
        {
            return View();
        }

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
