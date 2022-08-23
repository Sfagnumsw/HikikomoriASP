using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain.Repository
{
    public class RememberRepositoryEntity : IRemember
    {
        private readonly AppDbContext context;
        public RememberRepositoryEntity(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Remember>> AllRemember() => await context.Remember.ToListAsync();

        public async Task DeleteRemember(int RememberId)
        {
            context.Remember.Remove(new Remember() { Id = RememberId });
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Remember>> GetOnCategoryId(int CategoryId)
        {
            return await context.Remember.Where(i => i.CategoryId == CategoryId).ToListAsync();
        }

        public async Task SaveRemember(Remember obj)
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
