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
        public IEnumerable<Content> AllContent
        {
            get
            {
                return new List<Content>
                {
                    new Content { Name = "21 грамм", Category =  _category.GetCategories.First(), Genre = "Drama", Autor = "Alejandro Gonzalez Inarritu", CreationYear = 2003, Rating = 7, Replay = false},
                     new Content { Name = "21441 грамм", Category =  _category.GetCategories.First(), Genre = "Drama", Autor = "Alejandro Gonzalez Inarritu", CreationYear = 2003, Rating = 7, Replay = false}
                };
            }
        }

        public void DeliteContent(int id)
        {
            throw new NotImplementedException();
        }

        public Content GetOnId(int ContentId)
        {
            throw new NotImplementedException();
        }

        public void SaveContent(Content obj)
        {
            throw new NotImplementedException();
        }
    }
}
