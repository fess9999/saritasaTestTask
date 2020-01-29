using Cummins.Model.Base;

namespace Cummins.BusinessLogic.BusinessObjects
{
    public abstract class BusinessObject<TEntity> where TEntity : IEntity
    {
        public TEntity Entity { get; set; }
    }
}