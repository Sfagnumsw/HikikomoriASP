using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
    }
}
