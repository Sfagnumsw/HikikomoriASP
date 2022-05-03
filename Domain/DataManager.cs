using System.Linq;
using HikikomoriWEB.MVC.HelperInterfaces;

namespace HikikomoriWEB.Domain
{
    public class DataManager // централизованный класс для репозиториев
    {
        public IContent Content { get; set; }
        public ICategory Category { get; set; }
        public IRemember Remember { get; set; }

        public DataManager(IContent content, ICategory category, IRemember remember)
        {
            Category = category;
            Content = content;
            Remember = remember;
        }
    }
}
