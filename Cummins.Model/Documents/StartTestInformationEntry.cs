using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;
using Cummins.Model.Elements;

namespace Cummins.Model.Documents
{
    public class StartTestInformationEntry : Entity
    {
        [Required] public Product Product { get; set; }

        public decimal Quantity { get; set; }

        public string Initials { get; set; }

        public List<StartUpRequirement> StartUpRequirements { get; set; } = new List<StartUpRequirement>();
    }
}