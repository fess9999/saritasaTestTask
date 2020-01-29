using System.Collections.Generic;
using Cummins.Model.Base;

namespace Cummins.Model.Documents
{
    public class StartTestInformation : Entity
    {
        public TravelItem TravelItem { get; set; } = new TravelItem();

        public List<StartTestInformationEntry> StartTestInformationItems { get; set; } =
            new List<StartTestInformationEntry>();

        public Branch Branch { get; set; }

        public string Location { get; set; }

        public string LocationAtSite { get; set; }

        public decimal Total { get; set; }
    }
}