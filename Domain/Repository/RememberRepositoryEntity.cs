using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace HikikomoriWEB.Domain.Repository
{
    public class RememberRepositoryEntity : IRemember
    {
        private readonly AppDbContext context;
        public RememberRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Remember> AllRemember => context.Remember;

        public void DeliteRemember(int RememberId)
        {
            context.Remember.Remove(new Remember() { Id = RememberId });
            context.SaveChanges();
        }

        public IEnumerable<Remember> GetOnCategoryId(int CategoryId)
        {
            return context.Remember.Where(i => i.Category.Id == CategoryId);
        }

        public void SaveRemember(Remember obj)
        {
            if (obj.Id == default)
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
