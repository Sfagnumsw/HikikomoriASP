using HikikomoriWEB.MVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface ICategory //интерфейс связан с реализующим его классом (такая логика), чтобы передавать данные через model и view
    {
        Task<IEnumerable<Category>> GetCategories(); //показать все категории
        Task<Category> GetOnId(int CategoryId); // категория по id
    }
}
