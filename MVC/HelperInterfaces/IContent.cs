using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IContent // контент который уже посмотрел
    {
        IEnumerable<Content> AllContent { get;} //получить контент
        Content GetOnId(int ContentId); //контент по ID
        void SaveContent(Content obj); //сохранить
        void DeleteContent(int ContentId); //удалить
        IEnumerable<Content> GetOnCategoryId(int CategoryId); // получить весь контент из определенной категории
    }
}
