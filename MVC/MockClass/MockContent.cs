using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.MockClass
{
    public class MockContent : IContent
    {
        private readonly ICategory _category = new MockCategory();
        public IEnumerable<Content> AllContent // сделать заполнение от пользователя set
        {
            get
            {
                return new List<Content>
                {
                    new Content { Name = "21 грамм", Category =  _category.GetCategories.First(), Genre = "Drama", Autor = "Alejandro Gonzalez Inarritu", CreationYear = 2003, Img = "https://funart.pro/uploads/posts/2020-07/1596204984_1-p-21-gramm-film-2.jpg", Rating = 7, Replay = false},
                     new Content { Name = "21441 грамм", Category =  _category.GetCategories.First(), Genre = "Drama", Autor = "Alejandro Gonzalez Inarritu", CreationYear = 2003, Img = "https://funart.pro/uploads/posts/2020-07/1596204984_1-p-21-gramm-film-2.jpg", Rating = 7, Replay = false}
                };
            }
        }

        public Content GetOnId(int ContentId)
        {
            throw new NotImplementedException();
        }
    }
}
