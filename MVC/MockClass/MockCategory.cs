using HikikomoriWEB.MVC.HelperClass;
using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.MockClass
{
    public class MockCategory : ICategory
    {
        public IEnumerable<Category> GetCategories
        {
            get{
                return new List<Category>
                {
                    new Category { Name = "Фильмы" },
                    new Category { Name = "Игры" },
                    new Category { Name = "Книги" },
                    new Serials { Name = "Сериалы" },
                    new Category { Name = "Аниме" },
                    new Category { Name = "Мультфильмы" }
                };
            }
        }
    }
}
