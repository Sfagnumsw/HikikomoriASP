using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.WebPages.Html;

namespace HikikomoriWEB.Domain.Repository
{
    public class ContentRepositoryEntity : IContent // функционал модели
    {
        private readonly AppDbContext context;
        public ContentRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Content> AllContent => context.Content;

        public void DeliteContent(int Contentid)
        {
            context.Content.Remove(new Content() { Id = Contentid });
            context.SaveChanges();
        }

        public Content GetOnId(int ContentId)
        {
            return context.Content.FirstOrDefault(i => i.Id == ContentId);
        }

        //public IEnumerable<Content> GetOnCategoryId(int CategoryId)
        //{
        //    return context.Content.Where(i => i.CategoryId == CategoryId); // возможно не нужен, можно получить из модели категории поле list...
        //}

        public void SaveContent(Content obj)
        {
            if(obj.Id == default)
            {
                context.Entry(obj).State = EntityState.Added;
            }
            else
            {
                context.Entry(obj).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
