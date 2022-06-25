using RestSharp;
using Newtonsoft.Json.Linq;

namespace HikikomoriWEB.MVC.HelperInterfaces
{
    public interface IRestAPI
    {
        JObject GetQuote();
    }
}
