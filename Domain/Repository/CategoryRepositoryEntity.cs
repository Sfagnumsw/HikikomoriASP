using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace HikikomoriWEB.Domain.Repository
{
    public class CategoryRepositoryEntity : ICategory // функционал модели
    {
        private readonly AppDbContext context;
        public CategoryRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetCategories => context.Category;
        public Category GetOnId(int Categoryid)
        {
            return context.Category.FirstOrDefault(i => i.Id == Categoryid);
        }
    }
}
