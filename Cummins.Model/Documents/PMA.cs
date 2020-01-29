using System.Collections.Generic;
using Cummins.Model.Base;

namespace Cummins.Model.Documents
{
    public class PMA : Entity
    {
        public List<PMAEntry> PMAEntries { get; set; } = new List<PMAEntry>();

        public TravelItem TravelItem { get; set; }

        public Branch ServiceBranch { get; set; }

        public string DurationOfTheContract { get; set; }
    }
}