using System.Threading.Tasks;
using Cummins.BusinessLogic.BusinessObjects;
using Cummins.Model.Documents;

namespace Cummins.BusinessLogic.Services
{
    public class QuoteService : IQuoteService
    {
        public Task ShareAsync(BusinessObject<Quote> businessObject) => throw new System.NotImplementedException();

        public Task CloneAsync(BusinessObject<Quote> quote) => throw new System.NotImplementedException();

        public Task Accept(BusinessObject<Quote> quote) => throw new System.NotImplementedException();
    }
}