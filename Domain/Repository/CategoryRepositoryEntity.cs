using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain.Repository
{
    public class CategoryRepositoryEntity : ICategory // функционал модели
    {
        private readonly AppDbContext context;
        public CategoryRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Category>> GetCategories() => await context.Category.ToListAsync(); //полный список категорий

        public async Task<Category> GetOnId(int Categoryid)
        {
            return await context.Category.FirstOrDefaultAsync(i => i.Id == Categoryid);
        }
    }
}
