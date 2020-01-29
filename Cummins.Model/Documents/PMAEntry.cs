using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;
using Cummins.Model.Elements;

namespace Cummins.Model.Documents
{
    public class PMAEntry : Entity
    {
        [Required] public Product Product { get; set; }

        public decimal Quantity { get; set; }

        public decimal MaterialCost { get; set; }

        public int AnnualHoursVisit { get; set; }

        public int SemiAnnualHoursVisit { get; set; }

        public int QuarterlyHoursVisit { get; set; }
    }
}