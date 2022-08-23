using HikikomoriWEB.MVC.HelperInterfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HikikomoriWEB.Controllers.Support;

namespace HikikomoriWEB.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        private readonly IRemember _remember;
        private readonly IRestAPI _api;
        private readonly HalperMethods HM = new HalperMethods();
        public ContentController(IContent con, ICategory cat, IRemember rem, IRestAPI api)
        {
            _content = con;
            _category = cat;
            _remember = rem;
            _api = api;
        }
        #region Таблицы с контентом
        public async Task<IActionResult> ListFilms() //основная страница фильмов
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.listRate = await _content.GetOnCategoryId(10000);
            ViewBag.listRemember = await _remember.GetOnCategoryId(10000);
            return View();
        }

        public async Task<IActionResult> ListBooks(string contentId, string tableClass) //основная страница книг
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            await HM.Delete(_remember, _content, contentId, tableClass);
            ViewBag.listRate = await _content.GetOnCategoryId(10001);
            ViewBag.listRemember = await _remember.GetOnCategoryId(10001);
            return View();
        }

        public async Task<IActionResult> ListSerials() //основная страница сериалов
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.listRate = await _content.GetOnCategoryId(10003);
            ViewBag.listRemember = await _remember.GetOnCategoryId(10003);
            return View();
        }

        public async Task<IActionResult> ListMultfilms() //основная страница мультиков
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.listRate = await _content.GetOnCategoryId(10004);
            ViewBag.listRemember = await _remember.GetOnCategoryId(10004);
            return View();
        }

        public async Task<IActionResult> ListGames() //основная страница игр
        {
            //ViewBag.Quote = HM.QuoteAPI(_api);
            ViewBag.listRate = await _content.GetOnCategoryId(10002);
            ViewBag.listRemember = await _remember.GetOnCategoryId(10002);
            return View();
        }
        #endregion
    }
}
