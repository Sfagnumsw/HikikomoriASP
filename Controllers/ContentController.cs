using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
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
        #region Таблицы с контентом
        public ViewResult ListFilms(string contentId, string tableClass) //основная страница фильмов
        {
            //ViewBag.Quote = QuoteAPI();
            Delete(contentId, tableClass);
            ViewBag.listRate = _content.GetOnCategoryId(10000);
            ViewBag.listRemember = _remember.GetOnCategoryId(10000);
            return View();
        }

        public ViewResult ListBooks(string contentId, string tableClass) //основная страница книг
        {
            //ViewBag.Quote = QuoteAPI();
            Delete(contentId, tableClass);
            ViewBag.listRate = _content.GetOnCategoryId(10001);
            ViewBag.listRemember = _remember.GetOnCategoryId(10001);
            return View();
        }

        public ViewResult ListSerials(string contentId, string tableClass) //основная страница сериалов
        {
            //ViewBag.Quote = QuoteAPI();
            Delete(contentId, tableClass);
            ViewBag.listRate = _content.GetOnCategoryId(10003);
            ViewBag.listRemember = _remember.GetOnCategoryId(10003);
            return View();
        }

        public ViewResult ListMultfilms(string contentId, string tableClass) //основная страница мультиков
        {
            //ViewBag.Quote = QuoteAPI();
            Delete(contentId, tableClass);
            ViewBag.listRate = _content.GetOnCategoryId(10004);
            ViewBag.listRemember = _remember.GetOnCategoryId(10004);
            return View();
        }

        public ViewResult ListGames(string contentId, string tableClass) //основная страница игр
        {
            //ViewBag.Quote = QuoteAPI();
            Delete(contentId, tableClass);
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

        public void Delete(string contentId, string tableClass)
        {
            int id = Convert.ToInt32(contentId);
            if (tableClass == "table-list-rate")
            {
                _content.DeleteContent(id);
            }
            if(tableClass == "table-list-remember")
            {
                _remember.DeleteRemember(id);
            }
        }
        #endregion
    }
}
