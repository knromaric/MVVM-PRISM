using QuoteAppPrism.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuoteAppPrism.Interfaces
{
    public interface IQuotes
    {
        Task<List<Quote>> GetQuotes();
    }
}
