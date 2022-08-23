using HikikomoriWEB.MVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IContent // контент который уже посмотрел
    {
        Task<IEnumerable<Content>> AllContent(); //получить контент
        Task<Content> GetOnId(int ContentId); //контент по ID
        Task SaveContent(Content obj); //сохранить
        Task DeleteContent(int ContentId); //удалить
        Task<IEnumerable<Content>> GetOnCategoryId(int CategoryId); // получить весь контент из определенной категории
    }
}
