using Microsoft.AspNetCore.Mvc;

namespace HikikomoriWEB.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
