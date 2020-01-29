using System;
using System.ComponentModel.DataAnnotations;

namespace Cummins.Model.Base
{
    public class Entity
    {
        [Key] public Guid Id { get; set; }
    }
}