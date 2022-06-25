using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using HikikomoriWEB.MVC.HelperInterfaces;
using System.Net.Http;
using RestSharp;

namespace HikikomoriWEB.MVC.HelperClass
{
    public class ConnectionQuoteAPI : IRestAPI
    {

        public JObject GetQuote()
        {
            RestClient client = new RestClient("https://movies-quotes.p.rapidapi.com/quote");
            RestRequest request = new RestRequest() { Method = Method.Get };
            request.AddHeader("X-RapidAPI-Key", "dd794a4204mshf290cb22156b9a4p17e39cjsn95e339e2f71d");
            request.AddHeader("X-RapidAPI-Host", "movies-quotes.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            var data = JObject.Parse(response.Content);
            return data;
        }
    }
}
