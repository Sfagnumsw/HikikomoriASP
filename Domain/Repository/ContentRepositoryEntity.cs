using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HikikomoriWEB.Domain.Repository
{
    public class ContentRepositoryEntity : IContent
    {
        private readonly AppDbContext context;
        public ContentRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Content> AllContent => context.Content;

 
        public void DeliteContent(int id)
        {
            context.Content.Remove(new Content() { Id = id });
            context.SaveChanges();
        }

        public Content GetOnId(int ContentId)
        {
            return context.Content.FirstOrDefault(i => i.Id == ContentId);
        }

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
