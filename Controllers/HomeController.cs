using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HikikomoriWEB.Controllers.Support;
using System.Threading.Tasks;

namespace HikikomoriWEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        private readonly IRemember _remember;
        private readonly IRestAPI _api;
        private readonly HalperMethods HM = new HalperMethods();
        public HomeController(IContent con, ICategory cat, IRemember rem, IRestAPI api)
        {
            _content = con;
            _category = cat;
            _remember = rem;
            _api = api;
        }
 
        public IActionResult Index() //api
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            return View();
        }

        #region ФОРМЫ НА ГЛАВНОЙ СТРАНИЦЕ

        [HttpGet]
        public async Task<IActionResult> RateContent() //оценить
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.Categ = new SelectList(await _category.GetCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RateContent(Content objCon) //оценить
        {
            if (ModelState.IsValid)
            {
                await _content.SaveContent(objCon); 
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> RememberContent() //запомнить
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.Categ = new SelectList(await _category.GetCategories(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RememberContent(Remember obj) //запомнить
        {
            if (ModelState.IsValid)
            {
                await _remember.SaveRemember(obj);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        #endregion
    }  
}
