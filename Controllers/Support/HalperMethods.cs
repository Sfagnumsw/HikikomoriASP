using HikikomoriWEB.MVC.HelperInterfaces;
using HikikomoriWEB.MVC.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikikomoriWEB.Controllers.Support
{
    public class HalperMethods
    {
        public ResponseModel QuoteAPI(IRestAPI api) //заполнение объекта модели ответа запроса
        {
            var data = api.GetQuote();
            ResponseModel model = new ResponseModel()
            {
                Quote = data["quote"].Value<string>(),
                Character = data["character"].Value<string>(),
                Show = data["show"].Value<string>()
            };
            return model;
        }

        public async Task Delete(IRemember remember, IContent content, string contentId, string tableClass)
        {
            int id = Convert.ToInt32(contentId);
            if (tableClass == "table-list-rate")
            {
                await content.DeleteContent(id);
            }
            if (tableClass == "table-list-remember")
            {
                await remember.DeleteRemember(id);
            }
        }
    }
}
