using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Items
{
    public abstract class DocumentItem : Entity
    {
        [Required] public string Description { get; set; }

        public decimal Quantity { get; set; }

        public decimal Cost { get; set; }

        public decimal ExtendedCost { get; set; }

        public decimal SSADiscount { get; set; }

        public decimal GrossMargin { get; set; }

        public decimal GrossMarginPercent { get; set; }
    }
}