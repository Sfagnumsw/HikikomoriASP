using System.Linq;
using HikikomoriWEB.MVC.HelperInterfaces;

namespace HikikomoriWEB.Domain
{
    public class DataManager // централизованный класс для репозиториев
    {
        public IContent Content { get; set; }
        public ICategory Category { get; set; }

        public DataManager(IContent content, ICategory category)
        {
            Category = category;
            Content = content;
        }
    }
}
