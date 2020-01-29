using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public abstract class Element : Entity
    {
        [Required] public string Name { get; set; }

        public decimal Quantity { get; set; }

        public decimal Cost { get; set; }

        public decimal ExtendedCost { get; set; }

        public string Description { get; set; }
    }
}