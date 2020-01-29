using System;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Documents
{
    public class Quote : Document
    {
        public Contractor Contractor { get; set; }

        public Guid ContractorId { get; set; }

        [Required] public StartTestInformation StartTestInformation { get; set; }

        [Required] public PMA PMA { get; set; }
    }
}