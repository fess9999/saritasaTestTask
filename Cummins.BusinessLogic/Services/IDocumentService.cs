using System.Threading.Tasks;
using Cummins.BusinessLogic.BusinessObjects;
using Cummins.Model.Base;

namespace Cummins.BusinessLogic.Services
{
    public interface IDocumentService<in TDocumentBusinessObject, TDocument>
        where TDocumentBusinessObject : BusinessObject<TDocument> where TDocument : IEntity
    {
        Task ShareAsync(TDocumentBusinessObject businessObject);

        Task CloneAsync(TDocumentBusinessObject quote);

        Task Accept(TDocumentBusinessObject quote);
    }
}