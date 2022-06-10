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
        public HomeController(IContent con, ICategory cat)
        {
            _content = con;
            _category = cat;
        }
        public IActionResult Index()
        {
            return View();
        }

        IEnumerable<Category> categoryModel = new List<Category>()
        {
                new Category {Id = 10000, Name = "Фильмы" },
                new Category {Id = 10001, Name = "Книги"},
                new Category {Id = 10002, Name = "Игры"},
                new Category {Id = 10003, Name = "Сериалы"},
                new Category {Id = 10004, Name = "Мультфильмы"}
        };

        [HttpGet]
        public IActionResult RateContent()
        {
            ViewBag.Categ = new SelectList(categoryModel);
            return View();
        }

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
