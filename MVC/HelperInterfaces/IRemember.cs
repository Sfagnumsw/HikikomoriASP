using HikikomoriWEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IRemember // контент который надо отложить на будущее,еще не смотрел
    {
        IEnumerable<Remember> AllRemember { get; } //получить контент
        void SaveRemember(Remember obj); //сохранить
        void DeliteRemember(int RememberId); //удалить
        IEnumerable<Remember> GetOnCategoryId(int CategoryId); // получить весь контент из определенной категории
    }
}
