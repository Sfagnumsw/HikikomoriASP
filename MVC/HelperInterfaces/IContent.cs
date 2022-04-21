using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IContent
    {
        IEnumerable<Content> AllContent { get;} //получить или записать контент
        Content GetOnId(int ContentId); //контент по ID
    }
}
