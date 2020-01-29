using System;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Documents
{
    public class Quote : Document
    {
        public Contractor Contractor { get; set; }

        public Guid ContractorId { get; set; }

        [Required] public string State { get; set; }

        public bool IsShared { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsArchived { get; set; }

        [Required] public StartTestInformation StartTestInformation { get; set; }

        [Required] public PMA PMA { get; set; }
    }
}