using System;
using System.Collections.Generic;
using Cummins.Model.Base;
using Cummins.Model.Items;

namespace Cummins.Model.Documents
{
    public abstract class Document : Entity
    {
        public List<DocumentItem> Items { get; set; } = new List<DocumentItem>();

        public Project Project { get; set; }

        public Guid ProjectId { get; set; }
    }
}