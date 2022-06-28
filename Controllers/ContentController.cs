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

        public ViewResult ListFilms() //основная страница фильмов
        {
            var data = _api.GetQuote();
            ViewData["Quote"] = data["quote"].Value<string>();
            ViewData["Character"] = data["character"].Value<string>();
            ViewData["Show"] = data["show"].Value<string>();

            ViewBag.listRate = _content.GetOnCategoryId(10000);
            ViewBag.listRemember = _remember.GetOnCategoryId(10000);
            return View();
        }

        public ViewResult ListBooks() //основная страница книг
        {
            var data = _api.GetQuote();
            ViewData["Quote"] = data["quote"].Value<string>();
            ViewData["Character"] = data["character"].Value<string>();
            ViewData["Show"] = data["show"].Value<string>();

            ViewBag.listRate = _content.GetOnCategoryId(10001);
            ViewBag.listRemember = _remember.GetOnCategoryId(10001);
            return View();
        }

        public ViewResult ListSerials() //основная страница сериалов
        {
            var data = _api.GetQuote();
            ViewData["Quote"] = data["quote"].Value<string>();
            ViewData["Character"] = data["character"].Value<string>();
            ViewData["Show"] = data["show"].Value<string>();

            ViewBag.listRate = _content.GetOnCategoryId(10003);
            ViewBag.listRemember = _remember.GetOnCategoryId(10003);
            return View();
        }

        public ViewResult ListMultfilms() //основная страница мультиков
        {
            var data = _api.GetQuote();
            ViewData["Quote"] = data["quote"].Value<string>();
            ViewData["Character"] = data["character"].Value<string>();
            ViewData["Show"] = data["show"].Value<string>();

            ViewBag.listRate = _content.GetOnCategoryId(10004);
            ViewBag.listRemember = _remember.GetOnCategoryId(10004);
            return View();
        }

        public ViewResult ListGames() //основная страница игр
        {
            var data = _api.GetQuote();
            ViewData["Quote"] = data["quote"].Value<string>();
            ViewData["Character"] = data["character"].Value<string>();
            ViewData["Show"] = data["show"].Value<string>();

            ViewBag.listRate = _content.GetOnCategoryId(10002);
            ViewBag.listRemember = _remember.GetOnCategoryId(10002);
            return View();
        }
    }
}
