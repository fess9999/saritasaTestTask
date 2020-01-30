using System.Collections.Generic;
using Cummins.Model.Documents;
using Cummins.Model.Elements;

namespace Cummins.Model.Base
{
    public class Project : Entity
    {
        public string Name { get; set; }

        public List<Document> Documents { get; set; } = new List<Document>();
    }
}