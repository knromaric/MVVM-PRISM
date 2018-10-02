using Newtonsoft.Json;
using QuoteAppPrism.Interfaces;
using QuoteAppPrism.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuoteAppPrism.Services
{
    public class QuotesApi : IQuotes
    {
        public async Task<List<Quote>> GetQuotes()
        {
            string _quotesUrl = "http://quotesondesign.com/wp-json/posts?filter[orderby]=rand&filter[posts_per_page]=10";
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(_quotesUrl);
            return JsonConvert.DeserializeObject<List<Quote>>(response);
        }
    }
}
