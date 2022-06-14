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
        private readonly IRemember _remember;
        public ContentController(IContent con, ICategory cat, IRemember rem)
        {
            _content = con;
            _category = cat;
            _remember = rem;
        }

        public ViewResult ListFilms() //основная страница фильмов
        {
            return View();
        }
    }
}
