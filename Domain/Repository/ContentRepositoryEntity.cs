using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain.Repository
{
    public class ContentRepositoryEntity : IContent // функционал модели
    {
        private readonly AppDbContext context;
        public ContentRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Content>> AllContent() => await context.Content.ToListAsync(); // полный список контента

        public async Task DeleteContent(int Contentid) // удалить
        {
            context.Content.Remove(new Content() { Id = Contentid });
            await context.SaveChangesAsync();
        }

        public async Task<Content> GetOnId(int ContentId) // найти по ID
        {
            return await context.Content.FirstOrDefaultAsync(i => i.Id == ContentId);
        }

        public async Task<IEnumerable<Content>> GetOnCategoryId(int CategoryId) //получить контент по категориям
        {
            return await context.Content.Where(i => i.CategoryId == CategoryId).ToListAsync();
        }

        public async Task SaveContent(Content obj)  //сохранить
        {
            if (obj.Id == default)
            {
                context.Entry(obj).State = EntityState.Added;
            }
            else
            {
                context.Entry(obj).State = EntityState.Modified;
            }
            await context.SaveChangesAsync();
        }
    }
}
