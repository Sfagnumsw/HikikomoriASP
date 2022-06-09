using HikikomoriWEB.Domain;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HikikomoriWEB.Controllers
{
    public class ContentController : Controller
    {
        private readonly DataManager dataManager;
        public ContentController(IContent con,ICategory cat)
        {
            dataManager.Content = con;
            dataManager.Category = cat;
        }

        public ViewResult ListFilms() //основная страница фильмов
        {
            return View();
        }
    }
}
