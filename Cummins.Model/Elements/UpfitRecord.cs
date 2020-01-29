using System.Collections.Generic;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class UpfitRecord : Entity
    {
        public List<FileReference> FileReferences { get; set; } = new List<FileReference>();

        public string RFQNotes { get; set; }

        public bool PassToPurchasing { get; set; }

        public string Description { get; set; }

        public string SupplierProductNumber { get; set; }

        public string Manufacturer { get; set; }

        public decimal Quantity { get; set; }

        public decimal Cost { get; set; }

        public decimal PartsCost { get; set; }

        public string CpPnSku { get; set; }

        public decimal LaborHours { get; set; }

        public decimal LaborRate { get; set; }

        public decimal LaborCost { get; set; }

        public decimal FreightCost { get; set; }

        public string SupplierName { get; set; }

        public string SupplierQuoteNo { get; set; }

        public int SupplierDrawingLeadTime { get; set; }

        public int SupplierLeadTime { get; set; }
    }
}