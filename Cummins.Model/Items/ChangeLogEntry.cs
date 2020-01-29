using System;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;
using Cummins.Model.Documents;

namespace Cummins.Model.Items
{
    public class ChangeLogEntry : Entity
    {
        public string Name { get; set; }

        public DateTime ChangeDateTime { get; set; }

        [Required] public string Reason { get; set; }

        public double Order { get; set; }

        public Employee ModifiedBy { get; set; }

        public Document UnderlyingDocument { get; set; }
    }
}