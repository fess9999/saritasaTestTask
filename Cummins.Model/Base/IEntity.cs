using System;

namespace Cummins.Model.Base
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}