using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;
        private readonly IRemember _remember;
        private readonly IRestAPI _api;
        public ContentController(IContent con, ICategory cat, IRemember rem, IRestAPI api)
        {
            _content = con;
            _category = cat;
            _remember = rem;
            _api = api;
        }

        public ViewResult DeleteContent(int ContentId)
        {
            _content.DeleteContent(ContentId);
            return View();
        }
        #region Таблицы с контентом
        public ViewResult ListFilms() //основная страница фильмов
        {
            //ViewBag.Quote = QuoteAPI();
            ViewBag.listRate = _content.GetOnCategoryId(10000);
            ViewBag.listRemember = _remember.GetOnCategoryId(10000);
            return View();
        }

        public ViewResult ListBooks() //основная страница книг
        {
            //ViewBag.Quote = QuoteAPI();
            ViewBag.listRate = _content.GetOnCategoryId(10001);
            ViewBag.listRemember = _remember.GetOnCategoryId(10001);
            return View();
        }

        public ViewResult ListSerials() //основная страница сериалов
        {
            //ViewBag.Quote = QuoteAPI();
            ViewBag.listRate = _content.GetOnCategoryId(10003);
            ViewBag.listRemember = _remember.GetOnCategoryId(10003);
            return View();
        }

        public ViewResult ListMultfilms() //основная страница мультиков
        {
            //ViewBag.Quote = QuoteAPI();
            ViewBag.listRate = _content.GetOnCategoryId(10004);
            ViewBag.listRemember = _remember.GetOnCategoryId(10004);
            return View();
        }

        public ViewResult ListGames() //основная страница игр
        {
            //ViewBag.Quote = QuoteAPI();
            ViewBag.listRate = _content.GetOnCategoryId(10002);
            ViewBag.listRemember = _remember.GetOnCategoryId(10002);
            return View();
        }
        #endregion

        #region support
        public ResponseModel QuoteAPI() //заполнение объекта модели ответа от API
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
        #endregion
    }
}
