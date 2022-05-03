using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface ICategory //интерфейс связан с реализующим его классом (такая логика), чтобы передавать данные через model и view
    {
        IEnumerable<Category> GetCategories { get; } //показать все категории
        Category GetOnId(int CategoryId); // категория по id
    }
}
