using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;
using Cummins.Model.Items;

namespace Cummins.Model.Documents
{
    public abstract class Document : Entity
    {
        public Document Parent { get; set; }

        public List<DocumentItem> Items { get; set; } = new List<DocumentItem>();

        public Project Project { get; set; }

        public Guid ProjectId { get; set; }

        [Required] public Employee Owner { get; set; }

        public bool IsShared { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsArchived { get; set; }

        public DateTime? AcceptedDateTime { get; set; }
    }
}