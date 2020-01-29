using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Items
{
    public abstract class MaterialRequestItem : Entity
    {
        public string Description { get; set; }

        public decimal QuantityToOrder { get; set; }

        [Required] public string CPNo { get; set; }

        public string Supplier { get; set; }

        public decimal UnitPrice { get; set; }
    }
}