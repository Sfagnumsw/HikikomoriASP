using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.ViewModelsBag;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public ViewResult List()
        {
            ContentViewModel bag = new ContentViewModel();
            bag.allContent = _content.AllContent;
            return View(bag);
        }
    }
}
