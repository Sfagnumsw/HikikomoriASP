using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.ViewModelsBag
{
    public class ContentViewModel
    {
        public IEnumerable<Content> allContent { get; set; }
    }
}
