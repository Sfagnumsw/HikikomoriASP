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
        private readonly IRestAPI _api;
        public HomeController(IContent con, ICategory cat, IRemember rem, IRestAPI api)
        {
            _content = con;
            _category = cat;
            _remember = rem;
            _api = api;
        }
 
        public IActionResult Index() //api
        {
            //ViewBag.Quote = QuoteAPI();
            return View();
        }

        #region ФОРМЫ НА ГЛАВНОЙ СТРАНИЦЕ

        [HttpGet]
        public IActionResult RateContent() //оценить
        {
            //ViewBag.Quote = QuoteAPI();
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
            //ViewBag.Quote = QuoteAPI();
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

        #region support
        public ResponseModel QuoteAPI() //заполнение объекта модели ответа запроса
        {
            var data = _api.GetQuote();
            ResponseModel model = new ResponseModel()
            {
                Quote = data["quote"].Value<string>(),
                Character = data["character"].Value<string>(),
                Show = data["show"].Value<string>()
            };
            return model;
        }


    }
        #endregion

    
}
