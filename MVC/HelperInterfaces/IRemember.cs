using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IRemember // контент который надо отложить на будущее,еще не смотрел
    {
        Task<IEnumerable<Remember>> AllRemember(); //получить контент
        Task SaveRemember(Remember obj); //сохранить
        Task DeleteRemember(int RememberId); //удалить
        Task<IEnumerable<Remember>> GetOnCategoryId(int CategoryId); // получить весь контент из определенной категории
    }
}
