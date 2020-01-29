using Cummins.BusinessLogic.BusinessObjects;
using Cummins.Model.Documents;

namespace Cummins.BusinessLogic.Services
{
    public interface IQuoteService : IDocumentService<BusinessObject<Quote>, Quote>
    {
    }
}