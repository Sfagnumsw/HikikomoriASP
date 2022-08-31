using HikikomoriWEB.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HikikomoriWEB.Domain.Repository.Interfaces
{
    public interface IContentRepository<T>
    {
        Task<IEnumerable<T>> AllContent(); //получить контент
        Task<T> GetOnId(int ContentId); //контент по ID
        Task SaveContent(T obj); //сохранить
        Task DeleteContent(int ContentId); //удалить
        Task<IEnumerable<T>> GetOnCategoryId(int CategoryId); // получить весь контент из определенной категории
    }
}
