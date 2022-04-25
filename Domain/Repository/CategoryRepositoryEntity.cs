using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System.Collections.Generic;

namespace HikikomoriWEB.Domain.Repository
{
    public class CategoryRepositoryEntity : ICategory
    {
        private readonly AppDbContext context;
        public CategoryRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetCategories => context.Category;
    }
}
