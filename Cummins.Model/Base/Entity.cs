using System;
using System.ComponentModel.DataAnnotations;

namespace Cummins.Model.Base
{
    public class Entity : IEntity
    {
        [Key] public Guid Id { get; set; }
    }
}