using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Cummins.Model.Base;

namespace Cummins.Model.Elements
{
    public class UpfitElement : Element
    {
        public const string Standard = nameof(Standard);
        public const string NonStandard = nameof(NonStandard);

        public string Kind { get; set; } = Standard;


        public Category Category { get; set; }

        public Guid CategoryId { get; set; }

        public List<Product> Products { get; set; }

        public Employee CreatedBy { get; set; }

        public Guid? CreatedById { get; set; }

        // todo fess put unique idx
        [Required] public string UniqueId { get; set; }
    }
}