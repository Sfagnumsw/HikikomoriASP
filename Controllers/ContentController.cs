using HikikomoriWEB.MVC.HelperInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace HikikomoriWEB.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContent _content;
        private readonly ICategory _category;

        public ContentController(IContent con,ICategory cat)
        {
            _content = con;
            _category = cat;
        }

        public ViewResult ListFilms() //основная страница фильмов
        {
            return View();
        }

        public ViewResult RateFilms() //оценить просмотренные фильмы
        {
            return View();
        }



        public ViewResult RememberFilms() //запомнить фильмы на будущее
        {
            return View();
        }
    }
}
